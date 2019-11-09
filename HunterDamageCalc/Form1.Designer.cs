namespace HunterDamageCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.survTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mmTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.worldbuffsBox = new System.Windows.Forms.ListBox();
            this.consumesBox = new System.Windows.Forms.ListBox();
            this.buffsBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.agilityBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.weaponskillBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.weaponspeedBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.hitBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.quiverBox = new System.Windows.Forms.ComboBox();
            this.arrowBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dpsBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.bosshpBox = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numsimsBox = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.simButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.critBox = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.agilityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponskillBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponspeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosshpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsimsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.critBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(181, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "0/21/30 Lightning Reflexes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseEnter += new System.EventHandler(this.SurvSpecHover);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(12, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(196, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5/31/15 Survivalist Marksman";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseEnter += new System.EventHandler(this.SurvSpecHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Talent Spec:";
            // 
            // survTooltip
            // 
            this.survTooltip.AutoPopDelay = 500000;
            this.survTooltip.InitialDelay = 500;
            this.survTooltip.ReshowDelay = 100;
            this.survTooltip.ToolTipTitle = "0/21/30 Lightning Reflexes";
            this.survTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // mmTooltip
            // 
            this.mmTooltip.ToolTipTitle = "5/31/15 Survivalist Marksman";
            // 
            // worldbuffsBox
            // 
            this.worldbuffsBox.FormattingEnabled = true;
            this.worldbuffsBox.Items.AddRange(new object[] {
            "Rallying Cry of the Dragonslayer (+5% Crit)",
            "Spirit of Zandalar (+15% All Stats)",
            "Songflower Serenade (+15 All Stats, +5% Crit)",
            "Sayge\'s Fortune (+10% Damage)",
            "Sayge\'s Fortune (+10% Agility)"});
            this.worldbuffsBox.Location = new System.Drawing.Point(255, 27);
            this.worldbuffsBox.Name = "worldbuffsBox";
            this.worldbuffsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.worldbuffsBox.Size = new System.Drawing.Size(255, 82);
            this.worldbuffsBox.TabIndex = 5;
            this.worldbuffsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // consumesBox
            // 
            this.consumesBox.FormattingEnabled = true;
            this.consumesBox.Items.AddRange(new object[] {
            "Elixir of the Mongoose (+25 Agility, +2% Crit)",
            "Ground Scorpok Assay (+25 Agility)",
            "Grilled Squid (+10 Agility)"});
            this.consumesBox.Location = new System.Drawing.Point(516, 27);
            this.consumesBox.Name = "consumesBox";
            this.consumesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.consumesBox.Size = new System.Drawing.Size(255, 82);
            this.consumesBox.TabIndex = 6;
            // 
            // buffsBox
            // 
            this.buffsBox.FormattingEnabled = true;
            this.buffsBox.Items.AddRange(new object[] {
            "Hunter\'s Mark (110+ Attack Power)",
            "Aspect of the Hawk (+110 Attack Power)",
            "Blessing of Kings (+10% All Stats)",
            "Grace of Air Totem (+77 Agility)",
            "Leader of the Pack (+3% Crit)"});
            this.buffsBox.Location = new System.Drawing.Point(777, 27);
            this.buffsBox.Name = "buffsBox";
            this.buffsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.buffsBox.Size = new System.Drawing.Size(255, 82);
            this.buffsBox.TabIndex = 7;
            this.buffsBox.SelectedIndexChanged += new System.EventHandler(this.buffsBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "World Buffs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Consumables:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Other buffs/debuffs:";
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(579, 146);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultsBox.Size = new System.Drawing.Size(453, 262);
            this.resultsBox.TabIndex = 14;
            this.resultsBox.Text = "";
            // 
            // agilityBox
            // 
            this.agilityBox.Location = new System.Drawing.Point(14, 147);
            this.agilityBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.agilityBox.Name = "agilityBox";
            this.agilityBox.Size = new System.Drawing.Size(120, 20);
            this.agilityBox.TabIndex = 15;
            this.agilityBox.Value = new decimal(new int[] {
            112,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Agility from gear:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Added Attack Power:";
            // 
            // apBox
            // 
            this.apBox.Location = new System.Drawing.Point(14, 195);
            this.apBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.apBox.Name = "apBox";
            this.apBox.Size = new System.Drawing.Size(120, 20);
            this.apBox.TabIndex = 17;
            this.apBox.Value = new decimal(new int[] {
            296,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Weapon Skill:";
            // 
            // weaponskillBox
            // 
            this.weaponskillBox.Location = new System.Drawing.Point(180, 147);
            this.weaponskillBox.Maximum = new decimal(new int[] {
            315,
            0,
            0,
            0});
            this.weaponskillBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weaponskillBox.Name = "weaponskillBox";
            this.weaponskillBox.Size = new System.Drawing.Size(120, 20);
            this.weaponskillBox.TabIndex = 19;
            this.weaponskillBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Weapon Speed:";
            // 
            // weaponspeedBox
            // 
            this.weaponspeedBox.DecimalPlaces = 2;
            this.weaponspeedBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weaponspeedBox.Location = new System.Drawing.Point(180, 197);
            this.weaponspeedBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.weaponspeedBox.Name = "weaponspeedBox";
            this.weaponspeedBox.Size = new System.Drawing.Size(120, 20);
            this.weaponspeedBox.TabIndex = 21;
            this.weaponspeedBox.Value = new decimal(new int[] {
            26,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Added Hit Chance:";
            // 
            // hitBox
            // 
            this.hitBox.Location = new System.Drawing.Point(14, 250);
            this.hitBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.hitBox.Name = "hitBox";
            this.hitBox.Size = new System.Drawing.Size(120, 20);
            this.hitBox.TabIndex = 23;
            this.hitBox.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Quiver/Pouch:";
            // 
            // quiverBox
            // 
            this.quiverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quiverBox.FormattingEnabled = true;
            this.quiverBox.Items.AddRange(new object[] {
            "+13% Speed",
            "+14% Speed",
            "+15% Speed"});
            this.quiverBox.Location = new System.Drawing.Point(358, 147);
            this.quiverBox.Name = "quiverBox";
            this.quiverBox.Size = new System.Drawing.Size(193, 21);
            this.quiverBox.TabIndex = 27;
            // 
            // arrowBox
            // 
            this.arrowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrowBox.FormattingEnabled = true;
            this.arrowBox.Items.AddRange(new object[] {
            "Razor Arrow/Accurate Slugs (13 DPS )",
            "Thorium shell/Arrow (17.5 DPS )",
            "Doomshot (20 DPS )",
            "Miniature Cannon Balls (20.5 DPS )"});
            this.arrowBox.Location = new System.Drawing.Point(358, 197);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(193, 21);
            this.arrowBox.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Arrows/Bullets:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Weapon DPS:";
            // 
            // dpsBox
            // 
            this.dpsBox.DecimalPlaces = 2;
            this.dpsBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dpsBox.Location = new System.Drawing.Point(180, 250);
            this.dpsBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.dpsBox.Name = "dpsBox";
            this.dpsBox.Size = new System.Drawing.Size(120, 20);
            this.dpsBox.TabIndex = 30;
            this.dpsBox.Value = new decimal(new int[] {
            4019,
            0,
            0,
            131072});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Boss Health:";
            // 
            // bosshpBox
            // 
            this.bosshpBox.Location = new System.Drawing.Point(14, 374);
            this.bosshpBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.bosshpBox.Name = "bosshpBox";
            this.bosshpBox.Size = new System.Drawing.Size(120, 20);
            this.bosshpBox.TabIndex = 32;
            this.bosshpBox.Value = new decimal(new int[] {
            9150000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Number of Simulations:";
            // 
            // numsimsBox
            // 
            this.numsimsBox.Location = new System.Drawing.Point(180, 374);
            this.numsimsBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numsimsBox.Name = "numsimsBox";
            this.numsimsBox.Size = new System.Drawing.Size(120, 20);
            this.numsimsBox.TabIndex = 34;
            this.numsimsBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Simulation Configuration:";
            // 
            // simButton
            // 
            this.simButton.Location = new System.Drawing.Point(386, 374);
            this.simButton.Name = "simButton";
            this.simButton.Size = new System.Drawing.Size(136, 23);
            this.simButton.TabIndex = 37;
            this.simButton.Text = "Run Simulation";
            this.simButton.UseVisualStyleBackColor = true;
            this.simButton.Click += new System.EventHandler(this.SimulateClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Crit from gear:";
            // 
            // critBox
            // 
            this.critBox.Location = new System.Drawing.Point(14, 99);
            this.critBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.critBox.Name = "critBox";
            this.critBox.Size = new System.Drawing.Size(120, 20);
            this.critBox.TabIndex = 38;
            this.critBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(358, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Troll Hunter (has berserking)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(358, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Furious Howl on Pet";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(358, 298);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(189, 17);
            this.checkBox3.TabIndex = 42;
            this.checkBox3.Text = "Use Rapid Fire and Berserk on CD";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 436);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.critBox);
            this.Controls.Add(this.simButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numsimsBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bosshpBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dpsBox);
            this.Controls.Add(this.arrowBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.quiverBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hitBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.weaponspeedBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weaponskillBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.apBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agilityBox);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buffsBox);
            this.Controls.Add(this.consumesBox);
            this.Controls.Add(this.worldbuffsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WoW Classic Hunter DPS Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.agilityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponskillBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponspeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosshpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsimsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.critBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip survTooltip;
        private System.Windows.Forms.ToolTip mmTooltip;
        private System.Windows.Forms.ListBox worldbuffsBox;
        private System.Windows.Forms.ListBox consumesBox;
        private System.Windows.Forms.ListBox buffsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.NumericUpDown agilityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown apBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown weaponskillBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown weaponspeedBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown hitBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox quiverBox;
        private System.Windows.Forms.ComboBox arrowBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown dpsBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown bosshpBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numsimsBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button simButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown critBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

