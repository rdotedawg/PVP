namespace soma1
{
    partial class Mainform
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
            this.hook = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.BGworker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gigglenum = new System.Windows.Forms.Label();
            this.zombienum = new System.Windows.Forms.Label();
            this.blindnum = new System.Windows.Forms.Label();
            this.confusenum = new System.Windows.Forms.Label();
            this.slownum = new System.Windows.Forms.Label();
            this.weaknum = new System.Windows.Forms.Label();
            this.autogiggle = new System.Windows.Forms.CheckBox();
            this.autozombie = new System.Windows.Forms.CheckBox();
            this.autoblind = new System.Windows.Forms.CheckBox();
            this.autoconfuse = new System.Windows.Forms.CheckBox();
            this.autoslow = new System.Windows.Forms.CheckBox();
            this.autoweaken = new System.Windows.Forms.CheckBox();
            this.autosyrum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autohealth = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mpat = new System.Windows.Forms.Label();
            this.mpslider = new System.Windows.Forms.TrackBar();
            this.healat = new System.Windows.Forms.Label();
            this.healthslider = new System.Windows.Forms.TrackBar();
            this.automp = new System.Windows.Forms.CheckBox();
            this.healthnum = new System.Windows.Forms.Label();
            this.mpnum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botactive = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botspeed = new System.Windows.Forms.TrackBar();
            this.syrumspeed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.potioncheck = new System.Windows.Forms.CheckBox();
            this.syrumcheck = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrumspeed)).BeginInit();
            this.SuspendLayout();
            // 
            // hook
            // 
            this.hook.AutoSize = true;
            this.hook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hook.Location = new System.Drawing.Point(56, 18);
            this.hook.Name = "hook";
            this.hook.Size = new System.Drawing.Size(110, 13);
            this.hook.TabIndex = 1;
            this.hook.Text = "Process not found";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(141, 250);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 3;
            // 
            // BGworker
            // 
            this.BGworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGworker_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Character Name:";
            // 
            // charname
            // 
            this.charname.AutoSize = true;
            this.charname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charname.Location = new System.Drawing.Point(252, 18);
            this.charname.Name = "charname";
            this.charname.Size = new System.Drawing.Size(30, 13);
            this.charname.TabIndex = 6;
            this.charname.Text = "N/A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gigglenum);
            this.groupBox2.Controls.Add(this.zombienum);
            this.groupBox2.Controls.Add(this.blindnum);
            this.groupBox2.Controls.Add(this.confusenum);
            this.groupBox2.Controls.Add(this.slownum);
            this.groupBox2.Controls.Add(this.weaknum);
            this.groupBox2.Controls.Add(this.autogiggle);
            this.groupBox2.Controls.Add(this.autozombie);
            this.groupBox2.Controls.Add(this.autoblind);
            this.groupBox2.Controls.Add(this.autoconfuse);
            this.groupBox2.Controls.Add(this.autoslow);
            this.groupBox2.Controls.Add(this.autoweaken);
            this.groupBox2.Location = new System.Drawing.Point(159, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // gigglenum
            // 
            this.gigglenum.AutoSize = true;
            this.gigglenum.Location = new System.Drawing.Point(97, 139);
            this.gigglenum.Name = "gigglenum";
            this.gigglenum.Size = new System.Drawing.Size(13, 13);
            this.gigglenum.TabIndex = 17;
            this.gigglenum.Text = "0";
            // 
            // zombienum
            // 
            this.zombienum.AutoSize = true;
            this.zombienum.Location = new System.Drawing.Point(97, 116);
            this.zombienum.Name = "zombienum";
            this.zombienum.Size = new System.Drawing.Size(13, 13);
            this.zombienum.TabIndex = 17;
            this.zombienum.Text = "0";
            // 
            // blindnum
            // 
            this.blindnum.AutoSize = true;
            this.blindnum.Location = new System.Drawing.Point(97, 93);
            this.blindnum.Name = "blindnum";
            this.blindnum.Size = new System.Drawing.Size(13, 13);
            this.blindnum.TabIndex = 17;
            this.blindnum.Text = "0";
            // 
            // confusenum
            // 
            this.confusenum.AutoSize = true;
            this.confusenum.Location = new System.Drawing.Point(97, 69);
            this.confusenum.Name = "confusenum";
            this.confusenum.Size = new System.Drawing.Size(13, 13);
            this.confusenum.TabIndex = 16;
            this.confusenum.Text = "0";
            // 
            // slownum
            // 
            this.slownum.AutoSize = true;
            this.slownum.Location = new System.Drawing.Point(97, 46);
            this.slownum.Name = "slownum";
            this.slownum.Size = new System.Drawing.Size(13, 13);
            this.slownum.TabIndex = 7;
            this.slownum.Text = "0";
            // 
            // weaknum
            // 
            this.weaknum.AutoSize = true;
            this.weaknum.Location = new System.Drawing.Point(97, 20);
            this.weaknum.Name = "weaknum";
            this.weaknum.Size = new System.Drawing.Size(13, 13);
            this.weaknum.TabIndex = 6;
            this.weaknum.Text = "0";
            // 
            // autogiggle
            // 
            this.autogiggle.AutoSize = true;
            this.autogiggle.Location = new System.Drawing.Point(24, 138);
            this.autogiggle.Name = "autogiggle";
            this.autogiggle.Size = new System.Drawing.Size(56, 17);
            this.autogiggle.TabIndex = 5;
            this.autogiggle.Text = "Giggle";
            this.autogiggle.UseVisualStyleBackColor = true;
            // 
            // autozombie
            // 
            this.autozombie.AutoSize = true;
            this.autozombie.Checked = true;
            this.autozombie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autozombie.Location = new System.Drawing.Point(24, 115);
            this.autozombie.Name = "autozombie";
            this.autozombie.Size = new System.Drawing.Size(61, 17);
            this.autozombie.TabIndex = 4;
            this.autozombie.Text = "Zombie";
            this.autozombie.UseVisualStyleBackColor = true;
            // 
            // autoblind
            // 
            this.autoblind.AutoSize = true;
            this.autoblind.Checked = true;
            this.autoblind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoblind.Location = new System.Drawing.Point(24, 92);
            this.autoblind.Name = "autoblind";
            this.autoblind.Size = new System.Drawing.Size(49, 17);
            this.autoblind.TabIndex = 3;
            this.autoblind.Text = "Blind";
            this.autoblind.UseVisualStyleBackColor = true;
            // 
            // autoconfuse
            // 
            this.autoconfuse.AutoSize = true;
            this.autoconfuse.Checked = true;
            this.autoconfuse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoconfuse.Location = new System.Drawing.Point(24, 68);
            this.autoconfuse.Name = "autoconfuse";
            this.autoconfuse.Size = new System.Drawing.Size(65, 17);
            this.autoconfuse.TabIndex = 2;
            this.autoconfuse.Text = "Confuse";
            this.autoconfuse.UseVisualStyleBackColor = true;
            // 
            // autoslow
            // 
            this.autoslow.AutoSize = true;
            this.autoslow.Checked = true;
            this.autoslow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoslow.Location = new System.Drawing.Point(24, 45);
            this.autoslow.Name = "autoslow";
            this.autoslow.Size = new System.Drawing.Size(49, 17);
            this.autoslow.TabIndex = 1;
            this.autoslow.Text = "Slow";
            this.autoslow.UseVisualStyleBackColor = true;
            // 
            // autoweaken
            // 
            this.autoweaken.AutoSize = true;
            this.autoweaken.Checked = true;
            this.autoweaken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoweaken.Location = new System.Drawing.Point(24, 19);
            this.autoweaken.Name = "autoweaken";
            this.autoweaken.Size = new System.Drawing.Size(67, 17);
            this.autoweaken.TabIndex = 0;
            this.autoweaken.Text = "Weaken";
            this.autoweaken.UseVisualStyleBackColor = true;
            // 
            // autosyrum
            // 
            this.autosyrum.AutoSize = true;
            this.autosyrum.Checked = true;
            this.autosyrum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosyrum.Location = new System.Drawing.Point(183, 51);
            this.autosyrum.Name = "autosyrum";
            this.autosyrum.Size = new System.Drawing.Size(77, 17);
            this.autosyrum.TabIndex = 9;
            this.autosyrum.Text = "AutoSyrum";
            this.autosyrum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Potion Speed:";
            // 
            // autohealth
            // 
            this.autohealth.AutoSize = true;
            this.autohealth.Checked = true;
            this.autohealth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autohealth.Location = new System.Drawing.Point(24, 51);
            this.autohealth.Name = "autohealth";
            this.autohealth.Size = new System.Drawing.Size(82, 17);
            this.autohealth.TabIndex = 13;
            this.autohealth.Text = "Auto Health";
            this.autohealth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mpat);
            this.groupBox1.Controls.Add(this.mpslider);
            this.groupBox1.Controls.Add(this.healat);
            this.groupBox1.Controls.Add(this.healthslider);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // mpat
            // 
            this.mpat.AutoSize = true;
            this.mpat.Location = new System.Drawing.Point(4, 69);
            this.mpat.Name = "mpat";
            this.mpat.Size = new System.Drawing.Size(112, 13);
            this.mpat.TabIndex = 3;
            this.mpat.Text = "Use potion at 20% MP";
            // 
            // mpslider
            // 
            this.mpslider.Location = new System.Drawing.Point(12, 96);
            this.mpslider.Maximum = 99;
            this.mpslider.Minimum = 1;
            this.mpslider.Name = "mpslider";
            this.mpslider.Size = new System.Drawing.Size(104, 45);
            this.mpslider.TabIndex = 2;
            this.mpslider.Value = 20;
            this.mpslider.ValueChanged += new System.EventHandler(this.mpslider_ValueChanged);
            // 
            // healat
            // 
            this.healat.AutoSize = true;
            this.healat.Location = new System.Drawing.Point(4, 16);
            this.healat.Name = "healat";
            this.healat.Size = new System.Drawing.Size(111, 13);
            this.healat.TabIndex = 1;
            this.healat.Text = "Use potion at 90% HP";
            // 
            // healthslider
            // 
            this.healthslider.Location = new System.Drawing.Point(10, 37);
            this.healthslider.Maximum = 99;
            this.healthslider.Minimum = 1;
            this.healthslider.Name = "healthslider";
            this.healthslider.Size = new System.Drawing.Size(104, 45);
            this.healthslider.TabIndex = 0;
            this.healthslider.Value = 90;
            this.healthslider.ValueChanged += new System.EventHandler(this.healthslider_ValueChanged);
            // 
            // automp
            // 
            this.automp.AutoSize = true;
            this.automp.Checked = true;
            this.automp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automp.Location = new System.Drawing.Point(24, 74);
            this.automp.Name = "automp";
            this.automp.Size = new System.Drawing.Size(67, 17);
            this.automp.TabIndex = 15;
            this.automp.Text = "Auto MP";
            this.automp.UseVisualStyleBackColor = true;
            // 
            // healthnum
            // 
            this.healthnum.AutoSize = true;
            this.healthnum.Location = new System.Drawing.Point(113, 52);
            this.healthnum.Name = "healthnum";
            this.healthnum.Size = new System.Drawing.Size(13, 13);
            this.healthnum.TabIndex = 17;
            this.healthnum.Text = "0";
            // 
            // mpnum
            // 
            this.mpnum.AutoSize = true;
            this.mpnum.Location = new System.Drawing.Point(113, 75);
            this.mpnum.Name = "mpnum";
            this.mpnum.Size = new System.Drawing.Size(13, 13);
            this.mpnum.TabIndex = 18;
            this.mpnum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bot Active:";
            // 
            // botactive
            // 
            this.botactive.AutoSize = true;
            this.botactive.ForeColor = System.Drawing.Color.Red;
            this.botactive.Location = new System.Drawing.Point(399, 18);
            this.botactive.Name = "botactive";
            this.botactive.Size = new System.Drawing.Size(71, 13);
            this.botactive.TabIndex = 20;
            this.botactive.Text = "NOT ACTIVE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Press Insert to activate when ingame.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Syrum Speed:";
            // 
            // botspeed
            // 
            this.botspeed.Location = new System.Drawing.Point(381, 75);
            this.botspeed.Maximum = 2000;
            this.botspeed.Minimum = 50;
            this.botspeed.Name = "botspeed";
            this.botspeed.Size = new System.Drawing.Size(104, 45);
            this.botspeed.TabIndex = 4;
            this.botspeed.Value = 300;
            this.botspeed.ValueChanged += new System.EventHandler(this.botspeed_ValueChanged);
            // 
            // syrumspeed
            // 
            this.syrumspeed.Location = new System.Drawing.Point(381, 150);
            this.syrumspeed.Maximum = 2000;
            this.syrumspeed.Minimum = 50;
            this.syrumspeed.Name = "syrumspeed";
            this.syrumspeed.Size = new System.Drawing.Size(104, 45);
            this.syrumspeed.TabIndex = 24;
            this.syrumspeed.Value = 300;
            this.syrumspeed.ValueChanged += new System.EventHandler(this.syrumspeed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "300 ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "300 ms";
            // 
            // potioncheck
            // 
            this.potioncheck.AutoSize = true;
            this.potioncheck.Location = new System.Drawing.Point(352, 52);
            this.potioncheck.Name = "potioncheck";
            this.potioncheck.Size = new System.Drawing.Size(133, 17);
            this.potioncheck.TabIndex = 26;
            this.potioncheck.Text = "Random Potion Speed";
            this.potioncheck.UseVisualStyleBackColor = true;
            this.potioncheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // syrumcheck
            // 
            this.syrumcheck.AutoSize = true;
            this.syrumcheck.Location = new System.Drawing.Point(352, 127);
            this.syrumcheck.Name = "syrumcheck";
            this.syrumcheck.Size = new System.Drawing.Size(132, 17);
            this.syrumcheck.TabIndex = 27;
            this.syrumcheck.Text = "Random Syrum Speed";
            this.syrumcheck.UseVisualStyleBackColor = true;
            this.syrumcheck.CheckedChanged += new System.EventHandler(this.syrumcheck_CheckedChanged);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 257);
            this.Controls.Add(this.syrumcheck);
            this.Controls.Add(this.potioncheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.syrumspeed);
            this.Controls.Add(this.botspeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botactive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mpnum);
            this.Controls.Add(this.healthnum);
            this.Controls.Add(this.automp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autohealth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autosyrum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.charname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.hook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "PVP";
            this.Activated += new System.EventHandler(this.Mainform_Activated);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrumspeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hook;
        private System.Windows.Forms.Label Output;
        private System.ComponentModel.BackgroundWorker BGworker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label charname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox autoweaken;
        private System.Windows.Forms.CheckBox autozombie;
        private System.Windows.Forms.CheckBox autoblind;
        private System.Windows.Forms.CheckBox autoconfuse;
        private System.Windows.Forms.CheckBox autoslow;
        private System.Windows.Forms.CheckBox autosyrum;
        private System.Windows.Forms.CheckBox autogiggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox autohealth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox automp;
        private System.Windows.Forms.Label healat;
        private System.Windows.Forms.TrackBar healthslider;
        private System.Windows.Forms.Label mpat;
        private System.Windows.Forms.TrackBar mpslider;
        private System.Windows.Forms.Label confusenum;
        private System.Windows.Forms.Label slownum;
        private System.Windows.Forms.Label weaknum;
        private System.Windows.Forms.Label gigglenum;
        private System.Windows.Forms.Label zombienum;
        private System.Windows.Forms.Label blindnum;
        private System.Windows.Forms.Label healthnum;
        private System.Windows.Forms.Label mpnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label botactive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar botspeed;
        private System.Windows.Forms.TrackBar syrumspeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox potioncheck;
        private System.Windows.Forms.CheckBox syrumcheck;
    }
}

