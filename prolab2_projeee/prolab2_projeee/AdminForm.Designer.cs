namespace prolab2_projeee
{
    partial class AdminForm
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
            this.firma_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firma_turu = new System.Windows.Forms.TextBox();
            this.eklebttn = new System.Windows.Forms.Button();
            this.cikartbttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hizmetBedeli = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Var olan Firmalar";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma adi ";
            // 
            // firma_adi
            // 
            this.firma_adi.Location = new System.Drawing.Point(336, 78);
            this.firma_adi.Name = "firma_adi";
            this.firma_adi.Size = new System.Drawing.Size(262, 22);
            this.firma_adi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firma Türü";
            // 
            // firma_turu
            // 
            this.firma_turu.Location = new System.Drawing.Point(336, 128);
            this.firma_turu.Name = "firma_turu";
            this.firma_turu.Size = new System.Drawing.Size(262, 22);
            this.firma_turu.TabIndex = 6;
            // 
            // eklebttn
            // 
            this.eklebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebttn.Location = new System.Drawing.Point(336, 237);
            this.eklebttn.Name = "eklebttn";
            this.eklebttn.Size = new System.Drawing.Size(82, 36);
            this.eklebttn.TabIndex = 7;
            this.eklebttn.Text = "Ekle";
            this.eklebttn.UseVisualStyleBackColor = true;
            this.eklebttn.Click += new System.EventHandler(this.eklebttn_Click);
            // 
            // cikartbttn
            // 
            this.cikartbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikartbttn.Location = new System.Drawing.Point(518, 237);
            this.cikartbttn.Name = "cikartbttn";
            this.cikartbttn.Size = new System.Drawing.Size(80, 36);
            this.cikartbttn.TabIndex = 8;
            this.cikartbttn.Text = "Çıkart";
            this.cikartbttn.UseVisualStyleBackColor = true;
            this.cikartbttn.Click += new System.EventHandler(this.cikartbttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hizmet Bedeli (günlük)";
            // 
            // hizmetBedeli
            // 
            this.hizmetBedeli.Location = new System.Drawing.Point(336, 185);
            this.hizmetBedeli.Name = "hizmetBedeli";
            this.hizmetBedeli.Size = new System.Drawing.Size(262, 22);
            this.hizmetBedeli.TabIndex = 10;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Firma Adi";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firma Türü";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hizmet Bedeli";
            this.columnHeader3.Width = 100;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(669, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 412);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1053, 541);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.hizmetBedeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cikartbttn);
            this.Controls.Add(this.eklebttn);
            this.Controls.Add(this.firma_turu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firma_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firma_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firma_turu;
        private System.Windows.Forms.Button eklebttn;
        private System.Windows.Forms.Button cikartbttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hizmetBedeli;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;
    }
}