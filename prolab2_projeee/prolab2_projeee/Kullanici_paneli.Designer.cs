namespace prolab2_projeee
{
    partial class Kullanici_paneli
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
            this.label3 = new System.Windows.Forms.Label();
            this.NeredencomboBox = new System.Windows.Forms.ComboBox();
            this.NereyecomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bttnBiletAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yolculuk tarihi";
            // 
            // NeredencomboBox
            // 
            this.NeredencomboBox.FormattingEnabled = true;
            this.NeredencomboBox.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Ankara",
            "Eskişehir",
            "Konya",
            "Bilecik"});
            this.NeredencomboBox.Location = new System.Drawing.Point(214, 90);
            this.NeredencomboBox.Name = "NeredencomboBox";
            this.NeredencomboBox.Size = new System.Drawing.Size(247, 24);
            this.NeredencomboBox.TabIndex = 3;
            this.NeredencomboBox.SelectedIndexChanged += new System.EventHandler(this.NeredencomboBox_SelectedIndexChanged);
            // 
            // NereyecomboBox
            // 
            this.NereyecomboBox.FormattingEnabled = true;
            this.NereyecomboBox.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Ankara",
            "Eskişehir",
            "Konya",
            "Bilecik"});
            this.NereyecomboBox.Location = new System.Drawing.Point(214, 174);
            this.NereyecomboBox.Name = "NereyecomboBox";
            this.NereyecomboBox.Size = new System.Drawing.Size(247, 24);
            this.NereyecomboBox.TabIndex = 4;
            this.NereyecomboBox.SelectedIndexChanged += new System.EventHandler(this.NereyecomboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bttnBiletAra
            // 
            this.bttnBiletAra.Location = new System.Drawing.Point(263, 349);
            this.bttnBiletAra.Name = "bttnBiletAra";
            this.bttnBiletAra.Size = new System.Drawing.Size(157, 59);
            this.bttnBiletAra.TabIndex = 6;
            this.bttnBiletAra.Text = "Bilet Ara";
            this.bttnBiletAra.UseVisualStyleBackColor = true;
            this.bttnBiletAra.Click += new System.EventHandler(this.bttnBiletAra_Click);
            // 
            // Kullanici_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 507);
            this.Controls.Add(this.bttnBiletAra);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NereyecomboBox);
            this.Controls.Add(this.NeredencomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanici_paneli";
            this.Text = "Kullanici_paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NeredencomboBox;
        private System.Windows.Forms.ComboBox NereyecomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bttnBiletAra;
    }
}