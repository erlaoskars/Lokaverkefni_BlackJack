namespace Lokaverkefni_BlackJack
{
    partial class Leikslok
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
            this.lblPlayerpoints = new System.Windows.Forms.Label();
            this.lblCpupoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoneygol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerpoints
            // 
            this.lblPlayerpoints.AutoSize = true;
            this.lblPlayerpoints.BackColor = System.Drawing.Color.Silver;
            this.lblPlayerpoints.Location = new System.Drawing.Point(140, 76);
            this.lblPlayerpoints.Name = "lblPlayerpoints";
            this.lblPlayerpoints.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerpoints.TabIndex = 0;
            this.lblPlayerpoints.Text = "label1";
            this.lblPlayerpoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCpupoints
            // 
            this.lblCpupoints.AutoSize = true;
            this.lblCpupoints.BackColor = System.Drawing.Color.Silver;
            this.lblCpupoints.Location = new System.Drawing.Point(246, 76);
            this.lblCpupoints.Name = "lblCpupoints";
            this.lblCpupoints.Size = new System.Drawing.Size(35, 13);
            this.lblCpupoints.TabIndex = 1;
            this.lblCpupoints.Text = "label2";
            this.lblCpupoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(246, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(114, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Your Points";
            // 
            // lblMoneygol
            // 
            this.lblMoneygol.BackColor = System.Drawing.Color.Silver;
            this.lblMoneygol.Location = new System.Drawing.Point(140, 118);
            this.lblMoneygol.Name = "lblMoneygol";
            this.lblMoneygol.Size = new System.Drawing.Size(141, 28);
            this.lblMoneygol.TabIndex = 5;
            this.lblMoneygol.Text = "Money gained or lost";
            this.lblMoneygol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money gained or lost";
            // 
            // Leikslok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoneygol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCpupoints);
            this.Controls.Add(this.lblPlayerpoints);
            this.Name = "Leikslok";
            this.Text = "Leikslok";
            this.Load += new System.EventHandler(this.Leikslok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerpoints;
        private System.Windows.Forms.Label lblCpupoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoneygol;
        private System.Windows.Forms.Label label1;
    }
}