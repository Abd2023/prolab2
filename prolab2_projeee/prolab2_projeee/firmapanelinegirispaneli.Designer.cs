namespace prolab2_projeee
{
    partial class firmapanelinegirispaneli
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxfirmaAdi = new System.Windows.Forms.TextBox();
            this.textBoxFirmaSifresi = new System.Windows.Forms.TextBox();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma şifresi";
            // 
            // txtBoxfirmaAdi
            // 
            this.txtBoxfirmaAdi.Location = new System.Drawing.Point(344, 70);
            this.txtBoxfirmaAdi.Name = "txtBoxfirmaAdi";
            this.txtBoxfirmaAdi.Size = new System.Drawing.Size(173, 22);
            this.txtBoxfirmaAdi.TabIndex = 2;
            // 
            // textBoxFirmaSifresi
            // 
            this.textBoxFirmaSifresi.Location = new System.Drawing.Point(344, 134);
            this.textBoxFirmaSifresi.Name = "textBoxFirmaSifresi";
            this.textBoxFirmaSifresi.Size = new System.Drawing.Size(173, 22);
            this.textBoxFirmaSifresi.TabIndex = 3;
            // 
            // bttnGiris
            // 
            this.bttnGiris.Location = new System.Drawing.Point(370, 205);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(105, 46);
            this.bttnGiris.TabIndex = 4;
            this.bttnGiris.Text = "Giriş";
            this.bttnGiris.UseVisualStyleBackColor = true;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // firmapanelinegirispaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 468);
            this.Controls.Add(this.bttnGiris);
            this.Controls.Add(this.textBoxFirmaSifresi);
            this.Controls.Add(this.txtBoxfirmaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "firmapanelinegirispaneli";
            this.Text = "firmapanelinegirispaneli";
            this.Load += new System.EventHandler(this.firmapanelinegirispaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxfirmaAdi;
        private System.Windows.Forms.TextBox textBoxFirmaSifresi;
        private System.Windows.Forms.Button bttnGiris;
    }
}