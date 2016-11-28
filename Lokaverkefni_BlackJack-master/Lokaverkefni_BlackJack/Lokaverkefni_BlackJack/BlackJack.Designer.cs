namespace Lokaverkefni_BlackJack
{
    partial class BlackJack
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mInstructionsIS = new System.Windows.Forms.ToolStripMenuItem();
            this.mInstructionsENG = new System.Windows.Forms.ToolStripMenuItem();
            this.mInstructionsES = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignal = new System.Windows.Forms.Button();
            this.lblNafn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.labelspil = new System.Windows.Forms.Label();
            this.pbSpil = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStig = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.rbtn50 = new System.Windows.Forms.RadioButton();
            this.rbtn100 = new System.Windows.Forms.RadioButton();
            this.rbtn500 = new System.Windows.Forms.RadioButton();
            this.rbtn1000 = new System.Windows.Forms.RadioButton();
            this.gbBet = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).BeginInit();
            this.gbBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAuthors,
            this.mLogOut,
            this.mExit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mAuthors
            // 
            this.mAuthors.Name = "mAuthors";
            this.mAuthors.Size = new System.Drawing.Size(151, 22);
            this.mAuthors.Text = "Authors";
            this.mAuthors.Click += new System.EventHandler(this.mAuthors_Click);
            // 
            // mLogOut
            // 
            this.mLogOut.Name = "mLogOut";
            this.mLogOut.Size = new System.Drawing.Size(151, 22);
            this.mLogOut.Text = "Log out";
            this.mLogOut.Click += new System.EventHandler(this.mLogOut_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(151, 22);
            this.mExit.Text = "Exit to desktop";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mInstructionsIS,
            this.mInstructionsENG,
            this.mInstructionsES});
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // mInstructionsIS
            // 
            this.mInstructionsIS.Name = "mInstructionsIS";
            this.mInstructionsIS.Size = new System.Drawing.Size(162, 22);
            this.mInstructionsIS.Text = "Instructions IS";
            this.mInstructionsIS.Click += new System.EventHandler(this.mInstructionsIS_Click);
            // 
            // mInstructionsENG
            // 
            this.mInstructionsENG.Name = "mInstructionsENG";
            this.mInstructionsENG.Size = new System.Drawing.Size(162, 22);
            this.mInstructionsENG.Text = "Instructions ENG";
            this.mInstructionsENG.Click += new System.EventHandler(this.mInstructionsENG_Click);
            // 
            // mInstructionsES
            // 
            this.mInstructionsES.Name = "mInstructionsES";
            this.mInstructionsES.Size = new System.Drawing.Size(162, 22);
            this.mInstructionsES.Text = "Instructions ES";
            this.mInstructionsES.Click += new System.EventHandler(this.mInstructionsES_Click);
            // 
            // btnSignal
            // 
            this.btnSignal.Location = new System.Drawing.Point(184, 435);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(130, 37);
            this.btnSignal.TabIndex = 3;
            this.btnSignal.Text = "Signal";
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Visible = false;
            // 
            // lblNafn
            // 
            this.lblNafn.BackColor = System.Drawing.Color.Snow;
            this.lblNafn.Location = new System.Drawing.Point(69, 51);
            this.lblNafn.Name = "lblNafn";
            this.lblNafn.Size = new System.Drawing.Size(189, 24);
            this.lblNafn.TabIndex = 4;
            this.lblNafn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(264, 50);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(50, 24);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "400$";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHit
            // 
            this.BtnHit.Location = new System.Drawing.Point(34, 435);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(130, 37);
            this.BtnHit.TabIndex = 7;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Visible = false;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // labelspil
            // 
            this.labelspil.AutoSize = true;
            this.labelspil.Location = new System.Drawing.Point(11, 257);
            this.labelspil.Name = "labelspil";
            this.labelspil.Size = new System.Drawing.Size(0, 13);
            this.labelspil.TabIndex = 8;
            // 
            // pbSpil
            // 
            this.pbSpil.Image = global::Lokaverkefni_BlackJack.Properties.Resources._1A1;
            this.pbSpil.Location = new System.Drawing.Point(82, 102);
            this.pbSpil.Name = "pbSpil";
            this.pbSpil.Size = new System.Drawing.Size(189, 276);
            this.pbSpil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpil.TabIndex = 0;
            this.pbSpil.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stig:";
            // 
            // lblStig
            // 
            this.lblStig.BackColor = System.Drawing.Color.White;
            this.lblStig.Location = new System.Drawing.Point(69, 392);
            this.lblStig.Name = "lblStig";
            this.lblStig.Size = new System.Drawing.Size(55, 24);
            this.lblStig.TabIndex = 10;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(184, 485);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(130, 37);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // rbtn50
            // 
            this.rbtn50.AutoSize = true;
            this.rbtn50.Location = new System.Drawing.Point(16, 31);
            this.rbtn50.Name = "rbtn50";
            this.rbtn50.Size = new System.Drawing.Size(43, 17);
            this.rbtn50.TabIndex = 13;
            this.rbtn50.TabStop = true;
            this.rbtn50.Text = "50$";
            this.rbtn50.UseVisualStyleBackColor = true;
            // 
            // rbtn100
            // 
            this.rbtn100.AutoSize = true;
            this.rbtn100.Location = new System.Drawing.Point(16, 54);
            this.rbtn100.Name = "rbtn100";
            this.rbtn100.Size = new System.Drawing.Size(49, 17);
            this.rbtn100.TabIndex = 14;
            this.rbtn100.TabStop = true;
            this.rbtn100.Text = "100$";
            this.rbtn100.UseVisualStyleBackColor = true;
            // 
            // rbtn500
            // 
            this.rbtn500.AutoSize = true;
            this.rbtn500.Location = new System.Drawing.Point(71, 31);
            this.rbtn500.Name = "rbtn500";
            this.rbtn500.Size = new System.Drawing.Size(49, 17);
            this.rbtn500.TabIndex = 15;
            this.rbtn500.TabStop = true;
            this.rbtn500.Text = "500$";
            this.rbtn500.UseVisualStyleBackColor = true;
            // 
            // rbtn1000
            // 
            this.rbtn1000.AutoSize = true;
            this.rbtn1000.Location = new System.Drawing.Point(71, 54);
            this.rbtn1000.Name = "rbtn1000";
            this.rbtn1000.Size = new System.Drawing.Size(55, 17);
            this.rbtn1000.TabIndex = 16;
            this.rbtn1000.TabStop = true;
            this.rbtn1000.Text = "1000$";
            this.rbtn1000.UseVisualStyleBackColor = true;
            // 
            // gbBet
            // 
            this.gbBet.Controls.Add(this.btnStart);
            this.gbBet.Controls.Add(this.rbtn500);
            this.gbBet.Controls.Add(this.rbtn1000);
            this.gbBet.Controls.Add(this.rbtn50);
            this.gbBet.Controls.Add(this.rbtn100);
            this.gbBet.Location = new System.Drawing.Point(358, 50);
            this.gbBet.Name = "gbBet";
            this.gbBet.Size = new System.Drawing.Size(136, 125);
            this.gbBet.TabIndex = 17;
            this.gbBet.TabStop = false;
            this.gbBet.Text = "Bet:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 537);
            this.Controls.Add(this.gbBet);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblStig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelspil);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNafn);
            this.Controls.Add(this.btnSignal);
            this.Controls.Add(this.pbSpil);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).EndInit();
            this.gbBet.ResumeLayout(false);
            this.gbBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAuthors;
        private System.Windows.Forms.ToolStripMenuItem mLogOut;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mInstructionsIS;
        private System.Windows.Forms.ToolStripMenuItem mInstructionsENG;
        private System.Windows.Forms.ToolStripMenuItem mInstructionsES;
        private System.Windows.Forms.Button btnSignal;
        private System.Windows.Forms.Label lblNafn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Label labelspil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStig;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.RadioButton rbtn50;
        private System.Windows.Forms.RadioButton rbtn100;
        private System.Windows.Forms.RadioButton rbtn500;
        private System.Windows.Forms.RadioButton rbtn1000;
        private System.Windows.Forms.GroupBox gbBet;
        private System.Windows.Forms.Button btnStart;
    }
}