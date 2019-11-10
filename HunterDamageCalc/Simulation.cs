using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterDamageCalc
{
    public struct BuffData
    {
        public double Agility { get; set; }
        public double AllStats { get; set; }
        public double AgilityPerc { get; set; }
        public double AllStatsPerc { get; set; }
        public double Crit { get; set; }
        public double DamagePerc { get; set; }
        public double AttackPower { get; set; }

        public BuffData(double agi, double stats, double agip, double statsp, double crit, double dmg, double ap)
        {
            Agility = agi; AllStats = stats; AgilityPerc = agip/100; AllStatsPerc = statsp / 100; Crit = crit; DamagePerc = dmg / 100; AttackPower = ap;
        }
    }




    public struct PlayerData
    {
        public bool FuriousHowl { get; set; }
        public bool IsTroll { get; set; }
        public double AddedCrit { get; set; }
        public double Agility { get; set; }
        public double AttackPower { get; set; }
        public double Hit { get; set; }
        public double WeaponSkill { get; set; }
        public double WeaponSpeed { get; set; }
        public double WeaponDPS { get; set; }
        public double Quiver { get; set; }
        public double Arrows { get; set; }

        public PlayerData(bool howl, bool isTroll, double crit, double agi, double ap, double hit, double ws, double speed, double dps, double quiver, double arrow)
        {
            FuriousHowl = howl;  IsTroll = isTroll;  AddedCrit = crit; Agility = agi; AttackPower = ap; Hit = hit; WeaponSkill = ws; WeaponSpeed = speed; WeaponDPS = dps; Quiver = quiver; Arrows = arrow;
        }
    }

    public struct SimulationResults
    {
        public int NumActions { get; set; }
        public int NumCrits { get; set; } //NumMisses
        public int NumMisses { get; set; }
        public double CritPercentage { get; set; }
        public double TotalDamage { get; set; }
        public double TimeTaken { get; set; }
        public double DPS { get; set; }
        public double HighestAutoCrit { get; set; }
        public double HighestMultiCrit { get; set; }
        public double HighestAimedCrit { get; set; }
        public double PaneAgi { get; set; }
        public double PaneAP { get; set; }
        public double PaneDPS { get; set; }
        public double PaneCrit { get; set; }

        public SimulationResults(int ac, int crits, double crit, double dmg, double time, double dps, double acrit, double mcrit, double aicrit, double pagi, double pap, double pdps, double pcr, int nmiss)
        {
            NumActions = ac; NumCrits = crits; CritPercentage = crit; TotalDamage = dmg; TimeTaken = time; DPS = dps; HighestAutoCrit = acrit; HighestMultiCrit = mcrit; HighestAimedCrit = aicrit; PaneAgi = pagi; PaneAP = pap; PaneDPS = pdps; PaneCrit = pcr; NumMisses = nmiss;
        }
    }

    public struct AttackResult
    {
        public bool WasAttack { get; set; }
        public bool WasCriticalStrike { get; set; }
        public double Damage { get; set; }

        public AttackResult(bool att, bool crit, double dmg)
        {
            WasAttack = att; WasCriticalStrike = crit; Damage = dmg;
        }
    }

    public class Simulation
    {
        public PlayerData PlayerData { get; set; } = new PlayerData();
        public bool UseCDs { get; set; }
        private double HitChance = 0;
        private double AttackPower = 0;
        private double CriticalChance = 5;
        private double AttackSpeed = 0;
        private double DecreasedAttackSpeed = 0;
        private double CriticalStrikeMultiplier = 2;
        private double MultiShotDamage = 1;
        private double DamageMult = 1;
        private double TotalDPS = 0;


        private double MobHealth = 557770;

        private double CurrentSimulatedTime = 0;
        private double PreviousMultiShot = -10;
        private double PreviousAimedShot = -6;
        private double PreviousRapidFire = -300;
        private double PreviousBerserk = -180;
        private double PreviousFuriousHowl = 0;
        private double PreviousHawk = 0;
        private bool BerserkActive = false;
        private bool RapidFireActive = false;
        private bool ImpHawk = false;
        private bool HawkActive = false;
        private bool FuriousHowlActive = false;
        private bool FuriousHowl = false;

        public int CurrentSimulation { get; private set; }

        SimulationResults results = new SimulationResults();


        public void Init(BuffData buffdata, string spec)
        {
            Console.WriteLine(PlayerData.Agility);

            FuriousHowl = PlayerData.FuriousHowl;
            double agi = PlayerData.Agility + 127.0;
            if (spec == "MM")
            {
                buffdata.Crit += 8.0;
                CriticalStrikeMultiplier += 0.3;
                DamageMult += 0.8 + buffdata.DamagePerc;
                AttackPower += 100;
                MultiShotDamage += 0.15;
                ImpHawk = true;
                agi += (buffdata.Agility + buffdata.AllStats);
                agi *= (1.0 + ((buffdata.AgilityPerc / 100.0) + (buffdata.AllStatsPerc / 100.0)));
            }
            else if (spec == "SURV")
            {
                buffdata.Crit += 11.0;
                CriticalStrikeMultiplier += 0.3;
                DamageMult += 0.3 + buffdata.DamagePerc;
                agi += (buffdata.Agility + buffdata.AllStats);
                agi *= (1.0 + ((buffdata.AgilityPerc / 100.0) + 0.15 + (buffdata.AllStatsPerc / 100.0)));
            }
            HitChance = PlayerData.Hit;
            HitChance += ((PlayerData.WeaponSkill - 300.0) / 4.0) * 0.8;
            CriticalChance += 0.4 * (PlayerData.WeaponSkill - 300);
            CriticalChance += (agi / 53.0);
            CriticalChance += (PlayerData.AddedCrit / 100.0) + buffdata.Crit;
            AttackPower += agi * 2.0 + PlayerData.AttackPower + buffdata.AttackPower;
            TotalDPS = (AttackPower / 14.0) + PlayerData.WeaponDPS + PlayerData.Arrows;
            results.PaneAP = AttackPower;
            results.PaneAgi = agi;
            results.PaneDPS = TotalDPS;
            results.PaneCrit = CriticalChance;
        }


        private bool IsCritical()
        {
            Random rand = new Random();
            if (rand.NextDouble() <= (CriticalChance / 100.0))
                return true;

            return false;
        }

        private bool IsHit()
        {
            Random rand = new Random();
            double chanceToMiss = (100.0 + (HitChance - 9.0))/100;
            if (rand.NextDouble() >= chanceToMiss)
                return false;

            return true;
        }

        private AttackResult CastAttack(double addedTime = 0, double addedDamage = 0)
        {
            AttackResult res = new AttackResult();
            results.NumActions++;
            CurrentSimulatedTime += addedTime;
            double damage = TotalDPS * AttackSpeed + addedDamage;
            if (FuriousHowlActive)
            {
                damage += 51;
                FuriousHowlActive = false;
            }

            damage *= DamageMult;
            if (addedDamage == 120)
                damage *= MultiShotDamage;

            if (IsHit())
            { 
                if (IsCritical())
                {
                    damage *= CriticalStrikeMultiplier;
                    res.WasCriticalStrike = true;
                    results.NumCrits++;
                }
                res.Damage = damage;
                results.TotalDamage += damage;
                MobHealth -= damage;
            }
            else
            {
                results.NumMisses++;
            }
            return res;
        }

        private void CastRapidFire()
        {
            DecreasedAttackSpeed -= 0.4;
            PreviousRapidFire = CurrentSimulatedTime;
            CurrentSimulatedTime += 1;
        }

        private void CastBerserk()
        {
            DecreasedAttackSpeed -= 0.1;
            PreviousBerserk = CurrentSimulatedTime;
            CurrentSimulatedTime += 1;
        }


        private AttackResult DecideAndPerform()
        {
            AttackResult res = new AttackResult();

            if (ImpHawk && !HawkActive)
            {
                Random rand = new Random();
                if (rand.NextDouble() <= 0.05)
                {
                    DecreasedAttackSpeed -= 0.3;
                    HawkActive = true;

                    PreviousHawk = CurrentSimulatedTime;
                }
            }

            if (ImpHawk && HawkActive)
            {
                if (CurrentSimulatedTime - PreviousHawk >= 12)
                {
                    DecreasedAttackSpeed += 0.3;
                    HawkActive = false;
                }
            }

            if ((CurrentSimulatedTime - PreviousFuriousHowl) >= 10)
            {
                FuriousHowlActive = true;
                PreviousFuriousHowl = CurrentSimulatedTime;
            }

            if (UseCDs)
            {
                if ((CurrentSimulatedTime - PreviousRapidFire) >= 300)
                    CastRapidFire();

                if (((CurrentSimulatedTime - PreviousBerserk) >= 180) && PlayerData.IsTroll)
                    CastBerserk();
            }

            if (((CurrentSimulatedTime - PreviousRapidFire) >= 15) && RapidFireActive)
            {
                DecreasedAttackSpeed += 0.4;
                RapidFireActive = false;
            }

            if (((CurrentSimulatedTime - PreviousBerserk) >= 10) && BerserkActive)
            {
                DecreasedAttackSpeed += 0.1;
                BerserkActive = false;
            }

            if ((CurrentSimulatedTime - PreviousAimedShot) >= 6)
                res = CastAttack(3, 600);
            else if ((CurrentSimulatedTime - PreviousMultiShot) >= 10)
                res = CastAttack(AttackSpeed, 120);
            else
                res = CastAttack(AttackSpeed);

            results.TimeTaken = CurrentSimulatedTime;

            return res;
        }



        public SimulationResults Simulate(int mobhealth, int simulations, BackgroundWorker worker)
        {
            for (int curSim = 1; curSim <= simulations; curSim++)
            {
                CurrentSimulation = curSim;
                MobHealth = mobhealth;
                while (MobHealth > 0)
                {
                    DecideAndPerform();
                }
                worker.ReportProgress((int)(((double)curSim / (double)simulations) * 100.0));
            }
            results.TimeTaken = CurrentSimulatedTime;
            results.DPS = results.TotalDamage / results.TimeTaken;
            results.CritPercentage = (double)results.NumCrits / (double)results.NumActions; 

            return results;
        }


        public Simulation()
        {

        }
    }
}
