namespace Lokaverkefni_BlackJack
{
    partial class HaldaAfram
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnJa = new System.Windows.Forms.Button();
            this.btnNei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Til að halda áfram þarftu að leggja inn meiri peining, ef þú ýtir á já samþykkir " +
    "þú að leggja inn 500$";
            // 
            // btnJa
            // 
            this.btnJa.Location = new System.Drawing.Point(146, 104);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(87, 29);
            this.btnJa.TabIndex = 1;
            this.btnJa.Text = "Já";
            this.btnJa.UseVisualStyleBackColor = true;
            this.btnJa.Click += new System.EventHandler(this.btnJa_Click);
            // 
            // btnNei
            // 
            this.btnNei.Location = new System.Drawing.Point(239, 104);
            this.btnNei.Name = "btnNei";
            this.btnNei.Size = new System.Drawing.Size(87, 29);
            this.btnNei.TabIndex = 2;
            this.btnNei.Text = "Nei";
            this.btnNei.UseVisualStyleBackColor = true;
            this.btnNei.Click += new System.EventHandler(this.btnNei_Click);
            // 
            // HaldaAfram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 145);
            this.Controls.Add(this.btnNei);
            this.Controls.Add(this.btnJa);
            this.Controls.Add(this.label1);
            this.Name = "HaldaAfram";
            this.Text = "HaldaAfram";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJa;
        private System.Windows.Forms.Button btnNei;
    }
}