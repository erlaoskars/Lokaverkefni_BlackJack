﻿namespace Lokaverkefni_BlackJack
{
    partial class fLokaverkefni
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbLykilord = new System.Windows.Forms.TextBox();
            this.tbNotendanafn = new System.Windows.Forms.TextBox();
            this.btnSkraInn = new System.Windows.Forms.Button();
            this.btnNyskra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(242, 101);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 16);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Password:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(242, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 16);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Username:";
            // 
            // tbLykilord
            // 
            this.tbLykilord.Location = new System.Drawing.Point(354, 100);
            this.tbLykilord.Name = "tbLykilord";
            this.tbLykilord.Size = new System.Drawing.Size(206, 20);
            this.tbLykilord.TabIndex = 9;
            // 
            // tbNotendanafn
            // 
            this.tbNotendanafn.Location = new System.Drawing.Point(354, 74);
            this.tbNotendanafn.Name = "tbNotendanafn";
            this.tbNotendanafn.Size = new System.Drawing.Size(206, 20);
            this.tbNotendanafn.TabIndex = 8;
            // 
            // btnSkraInn
            // 
            this.btnSkraInn.Location = new System.Drawing.Point(413, 161);
            this.btnSkraInn.Name = "btnSkraInn";
            this.btnSkraInn.Size = new System.Drawing.Size(147, 42);
            this.btnSkraInn.TabIndex = 7;
            this.btnSkraInn.Text = "Log In";
            this.btnSkraInn.UseVisualStyleBackColor = true;
            this.btnSkraInn.Click += new System.EventHandler(this.btnSkraInn_Click);
            // 
            // btnNyskra
            // 
            this.btnNyskra.Location = new System.Drawing.Point(239, 161);
            this.btnNyskra.Name = "btnNyskra";
            this.btnNyskra.Size = new System.Drawing.Size(147, 42);
            this.btnNyskra.TabIndex = 6;
            this.btnNyskra.Text = "Sign Up";
            this.btnNyskra.UseVisualStyleBackColor = true;
            this.btnNyskra.Click += new System.EventHandler(this.btnNyskra_Click);
            // 
            // fLokaverkefni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Lokaverkefni_BlackJack.Properties.Resources.vegas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 269);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbLykilord);
            this.Controls.Add(this.tbNotendanafn);
            this.Controls.Add(this.btnSkraInn);
            this.Controls.Add(this.btnNyskra);
            this.Name = "fLokaverkefni";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.fLokaverkefni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbLykilord;
        internal System.Windows.Forms.TextBox tbNotendanafn;
        internal System.Windows.Forms.Button btnSkraInn;
        internal System.Windows.Forms.Button btnNyskra;
    }
}

