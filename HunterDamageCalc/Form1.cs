using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterDamageCalc
{
    public partial class Form1 : Form
    {
        Dictionary<int, BuffData> WorldBuffs = new Dictionary<int, BuffData>()
        {
            {0, new BuffData(0, 0, 0, 0, 5.0, 0, 0) },
            {1, new BuffData(0, 0, 0, 15.0, 0, 0, 0) },
            {2, new BuffData(0, 15.0, 0, 0, 5.0, 0, 0) },
            {3, new BuffData(0, 0, 0, 0, 0, 10.0, 0) },
            {4, new BuffData(0, 0, 10.0, 0, 0, 0, 0) },
        };

        Dictionary<int, BuffData> Consumables = new Dictionary<int, BuffData>()
        {
            {0, new BuffData(25.0, 0, 0, 0, 2.0, 0, 0) },
            {1, new BuffData(25.0, 0, 0, 0, 0, 0, 0) },
            {2, new BuffData(10.0, 0, 0, 0, 5.0, 0, 0) },
        };

        Dictionary<int, BuffData> Buffs = new Dictionary<int, BuffData>()
        {
            {0, new BuffData(0, 0, 0, 0, 0, 0, 110.0) },
            {1, new BuffData(0, 0, 0, 0, 0, 0, 110.0) },
            {2, new BuffData(0, 0, 0, 10.0, 0, 0, 0) },
            {3, new BuffData(77.0, 0, 0, 0, 0, 0, 0) },
            {4, new BuffData(0.0, 0, 0, 0, 3.0, 0, 0) },
        };

        public Form1()
        {
            InitializeComponent();
            mmTooltip.SetToolTip(radioButton2, HunterDamageCalc.Properties.Resources.MMTooltipString);
            mmTooltip.SetToolTip(radioButton1, HunterDamageCalc.Properties.Resources.SurvTooltipString);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        

        private void MMSpecHover(object sender, EventArgs e)
        {

        }
        private void SurvSpecHover(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buffsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SimulateClick(object sender, EventArgs e)
        {
            BuffData buffdata = new BuffData();
            Simulation simulation = new Simulation();
            simulation.UseCDs = checkBox3.Checked;

            for (int i = 0; i < worldbuffsBox.Items.Count; i++)
            {
                if (worldbuffsBox.GetSelected(i))
                {
                    buffdata.Agility += WorldBuffs[i].Agility;
                    buffdata.AllStats += WorldBuffs[i].AllStats;
                    buffdata.AgilityPerc += WorldBuffs[i].AgilityPerc;
                    buffdata.AllStatsPerc += WorldBuffs[i].AllStatsPerc;
                    buffdata.Crit += WorldBuffs[i].Crit;
                    buffdata.DamagePerc += WorldBuffs[i].DamagePerc;
                    buffdata.AttackPower += WorldBuffs[i].AttackPower;
                }
            }

            for (int i = 0; i < consumesBox.Items.Count; i++)
            {
                if (consumesBox.GetSelected(i))
                {
                    buffdata.Agility += Consumables[i].Agility;
                    buffdata.AllStats += Consumables[i].AllStats;
                    buffdata.AgilityPerc += Consumables[i].AgilityPerc;
                    buffdata.AllStatsPerc += Consumables[i].AllStatsPerc;
                    buffdata.Crit += Consumables[i].Crit;
                    buffdata.DamagePerc += Consumables[i].DamagePerc;
                    buffdata.AttackPower += Consumables[i].AttackPower;
                }
            }
            for (int i = 0; i < buffsBox.Items.Count; i++)
            {
                if (buffsBox.GetSelected(i))
                {
                    buffdata.Agility += Buffs[i].Agility;
                    buffdata.AllStats += Buffs[i].AllStats;
                    buffdata.AgilityPerc += Buffs[i].AgilityPerc;
                    buffdata.AllStatsPerc += Buffs[i].AllStatsPerc;
                    buffdata.Crit += Buffs[i].Crit;
                    buffdata.DamagePerc += Buffs[i].DamagePerc;
                    buffdata.AttackPower += Buffs[i].AttackPower;
                }
            }

            PlayerData pdata = new PlayerData();
            pdata.IsTroll = checkBox1.Checked;
            pdata.AddedCrit = (double)critBox.Value;
            pdata.Agility = (double)agilityBox.Value;
            pdata.AttackPower = (double)apBox.Value;
            pdata.Hit = (double)hitBox.Value;
            pdata.WeaponSkill = (double)weaponskillBox.Value;
            pdata.WeaponSpeed = (double)weaponspeedBox.Value;
            pdata.WeaponDPS = (double)dpsBox.Value;
            pdata.FuriousHowl = checkBox2.Checked;
            simulation.PlayerData = pdata;

            switch (quiverBox.SelectedIndex)
            {
                case 0:
                    pdata.Quiver = 13;
                    break;
                case 1:
                    pdata.Quiver = 14;
                    break;
                case 2:
                    pdata.Quiver = 15;
                    break;
            }

            switch (arrowBox.SelectedIndex)
            {
                case 0:
                    pdata.Arrows = 13;
                    break;
                case 1:
                    pdata.Arrows = 17.5;
                    break;
                case 2:
                    pdata.Arrows = 20;
                    break;
                case 3:
                    pdata.Arrows = 20.5;
                    break;
            }

            if (radioButton2.Checked)
                simulation.Init(buffdata, "MM");
            else
                simulation.Init(buffdata, "SURV");

            SimulationResults results = simulation.Simulate((int)bosshpBox.Value, (int)numsimsBox.Value);

            resultsBox.AppendText("------------------------------------------------------\n");
            resultsBox.AppendText(numsimsBox.Value.ToString() + " Simulations completed with " + bosshpBox.Value.ToString() + " Mob health\n");
            resultsBox.AppendText("\n");
            resultsBox.AppendText("Character Pane Agility: " + results.PaneAgi + "\n");
            resultsBox.AppendText("Character Pane AP: " + results.PaneAP + "\n");
            resultsBox.AppendText("Character Pane Crit: " + Math.Round(results.PaneCrit, 2) + "%\n");
            resultsBox.AppendText("Character Pane DPS: " + Math.Round(results.PaneDPS,2) + "\n");
            resultsBox.AppendText("\n");
            resultsBox.AppendText("Number of Actions: " + results.NumActions + "\n");
            resultsBox.AppendText("Number of Misses: " + results.NumMisses + "\n");
            double hitChance = (1.0 - ((double)results.NumMisses / (double)results.NumActions));
            resultsBox.AppendText("Effective Hit Chance: " + Math.Round(hitChance*100.0, 2) + "%\n");
            resultsBox.AppendText("Number of Critical strikes: " + results.NumCrits + "\n");
            resultsBox.AppendText("Effective Critical Strike Chance: " + Math.Round(results.CritPercentage*100.0,2) + "%\n");
            resultsBox.AppendText("Total Damage: " + Math.Round(results.TotalDamage) + "\n");
            resultsBox.AppendText("Time Taken: " + results.TimeTaken + "\n");
            resultsBox.AppendText("DPS: " + Math.Round(results.DPS,2) + "\n");
            resultsBox.AppendText("------------------------------------------------------\n");
        }
    }
}
