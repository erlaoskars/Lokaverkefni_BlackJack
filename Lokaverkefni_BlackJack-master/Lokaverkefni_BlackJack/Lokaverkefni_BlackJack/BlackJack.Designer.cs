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
            this.button2 = new System.Windows.Forms.Button();
            this.lblNafn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.labelspil = new System.Windows.Forms.Label();
            this.pbSpil = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Signal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblNafn
            // 
            this.lblNafn.BackColor = System.Drawing.Color.Snow;
            this.lblNafn.Location = new System.Drawing.Point(86, 51);
            this.lblNafn.Name = "lblNafn";
            this.lblNafn.Size = new System.Drawing.Size(189, 24);
            this.lblNafn.TabIndex = 4;
            this.lblNafn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(281, 50);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(50, 24);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "400$";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHit
            // 
            this.BtnHit.Location = new System.Drawing.Point(28, 407);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(143, 37);
            this.BtnHit.TabIndex = 7;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // labelspil
            // 
            this.labelspil.AutoSize = true;
            this.labelspil.Location = new System.Drawing.Point(28, 257);
            this.labelspil.Name = "labelspil";
            this.labelspil.Size = new System.Drawing.Size(0, 13);
            this.labelspil.TabIndex = 8;
            // 
            // pbSpil
            // 
            this.pbSpil.Image = global::Lokaverkefni_BlackJack.Properties.Resources._1A1;
            this.pbSpil.Location = new System.Drawing.Point(86, 101);
            this.pbSpil.Name = "pbSpil";
            this.pbSpil.Size = new System.Drawing.Size(189, 276);
            this.pbSpil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpil.TabIndex = 0;
            this.pbSpil.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 473);
            this.Controls.Add(this.labelspil);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNafn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbSpil);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNafn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Label labelspil;
    }
}