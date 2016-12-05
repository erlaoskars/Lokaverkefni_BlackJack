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
            this.labelspil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStig = new System.Windows.Forms.Label();
            this.gbBet = new System.Windows.Forms.GroupBox();
            this.tbBet = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.pbtolvuspil1 = new System.Windows.Forms.PictureBox();
            this.pbtolvuspil2 = new System.Windows.Forms.PictureBox();
            this.pbtolvuspil3 = new System.Windows.Forms.PictureBox();
            this.pbtolvuspil4 = new System.Windows.Forms.PictureBox();
            this.pbtolvuspil5 = new System.Windows.Forms.PictureBox();
            this.pbtolvuspil6 = new System.Windows.Forms.PictureBox();
            this.pbSpil = new System.Windows.Forms.PictureBox();
            this.pbspil2 = new System.Windows.Forms.PictureBox();
            this.pbspil3 = new System.Windows.Forms.PictureBox();
            this.pbspil4 = new System.Windows.Forms.PictureBox();
            this.pbspil5 = new System.Windows.Forms.PictureBox();
            this.pbspil6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.BackgroundImage = global::Lokaverkefni_BlackJack.Properties.Resources.BlackJackBorð;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAuthors,
            this.mLogOut,
            this.mExit});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            this.instructionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mInstructionsIS,
            this.mInstructionsENG,
            this.mInstructionsES});
            this.instructionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
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
            this.btnSignal.Location = new System.Drawing.Point(630, 460);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(130, 37);
            this.btnSignal.TabIndex = 3;
            this.btnSignal.Text = "Signal";
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Visible = false;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // lblNafn
            // 
            this.lblNafn.BackColor = System.Drawing.Color.Snow;
            this.lblNafn.Location = new System.Drawing.Point(507, 41);
            this.lblNafn.Name = "lblNafn";
            this.lblNafn.Size = new System.Drawing.Size(189, 24);
            this.lblNafn.TabIndex = 4;
            this.lblNafn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(697, 41);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(50, 24);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "400$";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelspil
            // 
            this.labelspil.AutoSize = true;
            this.labelspil.Location = new System.Drawing.Point(11, 257);
            this.labelspil.Name = "labelspil";
            this.labelspil.Size = new System.Drawing.Size(0, 13);
            this.labelspil.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stig:";
            // 
            // lblStig
            // 
            this.lblStig.BackColor = System.Drawing.Color.White;
            this.lblStig.Location = new System.Drawing.Point(91, 441);
            this.lblStig.Name = "lblStig";
            this.lblStig.Size = new System.Drawing.Size(64, 24);
            this.lblStig.TabIndex = 10;
            this.lblStig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBet
            // 
            this.gbBet.BackColor = System.Drawing.Color.Transparent;
            this.gbBet.Controls.Add(this.tbBet);
            this.gbBet.Controls.Add(this.btnStart);
            this.gbBet.ForeColor = System.Drawing.Color.White;
            this.gbBet.Location = new System.Drawing.Point(555, 170);
            this.gbBet.Name = "gbBet";
            this.gbBet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbBet.Size = new System.Drawing.Size(141, 145);
            this.gbBet.TabIndex = 17;
            this.gbBet.TabStop = false;
            this.gbBet.Text = "Bet:";
            // 
            // tbBet
            // 
            this.tbBet.Location = new System.Drawing.Point(6, 29);
            this.tbBet.Name = "tbBet";
            this.tbBet.Size = new System.Drawing.Size(129, 20);
            this.tbBet.TabIndex = 18;
            this.tbBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBet.TextChanged += new System.EventHandler(this.tbBet_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.Location = new System.Drawing.Point(6, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 58);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(485, 460);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(129, 37);
            this.btnHit.TabIndex = 25;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // pbtolvuspil1
            // 
            this.pbtolvuspil1.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil1.Location = new System.Drawing.Point(1024, 105);
            this.pbtolvuspil1.Name = "pbtolvuspil1";
            this.pbtolvuspil1.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil1.TabIndex = 26;
            this.pbtolvuspil1.TabStop = false;
            // 
            // pbtolvuspil2
            // 
            this.pbtolvuspil2.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil2.Location = new System.Drawing.Point(975, 105);
            this.pbtolvuspil2.Name = "pbtolvuspil2";
            this.pbtolvuspil2.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil2.TabIndex = 29;
            this.pbtolvuspil2.TabStop = false;
            // 
            // pbtolvuspil3
            // 
            this.pbtolvuspil3.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil3.Location = new System.Drawing.Point(921, 105);
            this.pbtolvuspil3.Name = "pbtolvuspil3";
            this.pbtolvuspil3.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil3.TabIndex = 27;
            this.pbtolvuspil3.TabStop = false;
            // 
            // pbtolvuspil4
            // 
            this.pbtolvuspil4.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil4.Location = new System.Drawing.Point(877, 105);
            this.pbtolvuspil4.Name = "pbtolvuspil4";
            this.pbtolvuspil4.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil4.TabIndex = 28;
            this.pbtolvuspil4.TabStop = false;
            // 
            // pbtolvuspil5
            // 
            this.pbtolvuspil5.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil5.Location = new System.Drawing.Point(829, 105);
            this.pbtolvuspil5.Name = "pbtolvuspil5";
            this.pbtolvuspil5.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil5.TabIndex = 30;
            this.pbtolvuspil5.TabStop = false;
            // 
            // pbtolvuspil6
            // 
            this.pbtolvuspil6.BackColor = System.Drawing.Color.Transparent;
            this.pbtolvuspil6.Location = new System.Drawing.Point(780, 105);
            this.pbtolvuspil6.Name = "pbtolvuspil6";
            this.pbtolvuspil6.Size = new System.Drawing.Size(189, 276);
            this.pbtolvuspil6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtolvuspil6.TabIndex = 31;
            this.pbtolvuspil6.TabStop = false;
            // 
            // pbSpil
            // 
            this.pbSpil.BackColor = System.Drawing.Color.Transparent;
            this.pbSpil.Location = new System.Drawing.Point(17, 105);
            this.pbSpil.Name = "pbSpil";
            this.pbSpil.Size = new System.Drawing.Size(189, 276);
            this.pbSpil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpil.TabIndex = 0;
            this.pbSpil.TabStop = false;
            // 
            // pbspil2
            // 
            this.pbspil2.BackColor = System.Drawing.Color.Transparent;
            this.pbspil2.Location = new System.Drawing.Point(72, 105);
            this.pbspil2.Name = "pbspil2";
            this.pbspil2.Size = new System.Drawing.Size(189, 276);
            this.pbspil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbspil2.TabIndex = 20;
            this.pbspil2.TabStop = false;
            // 
            // pbspil3
            // 
            this.pbspil3.BackColor = System.Drawing.Color.Transparent;
            this.pbspil3.Location = new System.Drawing.Point(124, 105);
            this.pbspil3.Name = "pbspil3";
            this.pbspil3.Size = new System.Drawing.Size(189, 276);
            this.pbspil3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbspil3.TabIndex = 18;
            this.pbspil3.TabStop = false;
            // 
            // pbspil4
            // 
            this.pbspil4.BackColor = System.Drawing.Color.Transparent;
            this.pbspil4.Location = new System.Drawing.Point(178, 105);
            this.pbspil4.Name = "pbspil4";
            this.pbspil4.Size = new System.Drawing.Size(189, 276);
            this.pbspil4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbspil4.TabIndex = 19;
            this.pbspil4.TabStop = false;
            // 
            // pbspil5
            // 
            this.pbspil5.BackColor = System.Drawing.Color.Transparent;
            this.pbspil5.Location = new System.Drawing.Point(229, 105);
            this.pbspil5.Name = "pbspil5";
            this.pbspil5.Size = new System.Drawing.Size(189, 276);
            this.pbspil5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbspil5.TabIndex = 21;
            this.pbspil5.TabStop = false;
            // 
            // pbspil6
            // 
            this.pbspil6.BackColor = System.Drawing.Color.Transparent;
            this.pbspil6.Location = new System.Drawing.Point(278, 105);
            this.pbspil6.Name = "pbspil6";
            this.pbspil6.Size = new System.Drawing.Size(189, 276);
            this.pbspil6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbspil6.TabIndex = 22;
            this.pbspil6.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokaverkefni_BlackJack.Properties.Resources.BlackJackBorð;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 537);
            this.ControlBox = false;
            this.Controls.Add(this.pbtolvuspil1);
            this.Controls.Add(this.pbtolvuspil2);
            this.Controls.Add(this.pbtolvuspil3);
            this.Controls.Add(this.pbtolvuspil4);
            this.Controls.Add(this.pbtolvuspil5);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.pbSpil);
            this.Controls.Add(this.pbspil2);
            this.Controls.Add(this.pbspil3);
            this.Controls.Add(this.gbBet);
            this.Controls.Add(this.lblStig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelspil);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNafn);
            this.Controls.Add(this.btnSignal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbspil4);
            this.Controls.Add(this.pbspil5);
            this.Controls.Add(this.pbspil6);
            this.Controls.Add(this.pbtolvuspil6);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbBet.ResumeLayout(false);
            this.gbBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtolvuspil6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbspil6)).EndInit();
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
        private System.Windows.Forms.Label labelspil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStig;
        private System.Windows.Forms.GroupBox gbBet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbspil3;
        private System.Windows.Forms.PictureBox pbspil4;
        private System.Windows.Forms.PictureBox pbspil2;
        private System.Windows.Forms.PictureBox pbspil5;
        private System.Windows.Forms.PictureBox pbspil6;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.PictureBox pbtolvuspil1;
        private System.Windows.Forms.PictureBox pbtolvuspil2;
        private System.Windows.Forms.PictureBox pbtolvuspil3;
        private System.Windows.Forms.PictureBox pbtolvuspil4;
        private System.Windows.Forms.PictureBox pbtolvuspil5;
        private System.Windows.Forms.PictureBox pbtolvuspil6;
    }
}