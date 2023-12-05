namespace prolab2_projeee
{
    partial class Rezervasiyon_Sistemi
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
            this.adminbttn = new System.Windows.Forms.Button();
            this.firmabttn = new System.Windows.Forms.Button();
            this.kullanicibttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminbttn
            // 
            this.adminbttn.Location = new System.Drawing.Point(51, 233);
            this.adminbttn.Name = "adminbttn";
            this.adminbttn.Size = new System.Drawing.Size(118, 83);
            this.adminbttn.TabIndex = 0;
            this.adminbttn.Text = "Admin";
            this.adminbttn.UseVisualStyleBackColor = true;
            this.adminbttn.Click += new System.EventHandler(this.adminbttn_Click);
            // 
            // firmabttn
            // 
            this.firmabttn.Location = new System.Drawing.Point(266, 233);
            this.firmabttn.Name = "firmabttn";
            this.firmabttn.Size = new System.Drawing.Size(118, 83);
            this.firmabttn.TabIndex = 1;
            this.firmabttn.Text = "Firma";
            this.firmabttn.UseVisualStyleBackColor = true;
            this.firmabttn.Click += new System.EventHandler(this.firmabttn_Click);
            // 
            // kullanicibttn
            // 
            this.kullanicibttn.Location = new System.Drawing.Point(482, 233);
            this.kullanicibttn.Name = "kullanicibttn";
            this.kullanicibttn.Size = new System.Drawing.Size(118, 83);
            this.kullanicibttn.TabIndex = 2;
            this.kullanicibttn.Text = "Kullanıcı Paneli";
            this.kullanicibttn.UseVisualStyleBackColor = true;
            this.kullanicibttn.Click += new System.EventHandler(this.kullanicibttn_Click);
            // 
            // Rezervasiyon_Sistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.kullanicibttn);
            this.Controls.Add(this.firmabttn);
            this.Controls.Add(this.adminbttn);
            this.Name = "Rezervasiyon_Sistemi";
            this.Text = "Rezervasiyon_Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminbttn;
        private System.Windows.Forms.Button firmabttn;
        private System.Windows.Forms.Button kullanicibttn;
    }
}