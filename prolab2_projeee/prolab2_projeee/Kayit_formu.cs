using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2_projeee
{
    public partial class Kayit_formu : Form
    {

        public string KoltukSayisi { get; set; }


        public Kayit_formu(string koltuk_sayisi)
        {
            InitializeComponent();

            //this.KoltukSayisi = koltukSayisi;
            int sira = int.Parse(koltuk_sayisi);

            // Koltukları doldurun
            KoltukDoldur(sira );



        }


        void KoltukDoldur(int koltukSayisi)
        {
            // Önceki koltukları temizleyin
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Text != "Kaydet")
                {
                    this.Controls.Remove(ctrl);
                }
            }

            int koltukNo = 1;
            for (int i = 0; i < koltukSayisi / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltuk.Click += Koltuk_Click; // Koltuk_Click adında bir olay işleyici oluşturmanız gerekiyor
                    koltukNo++;
                    this.Controls.Add(koltuk);
                }
            }

            // Eğer koltukSayisi 4'ün tam katı değilse, son satırdaki kalan koltukları ekleyin
            for (int j = 0; j < koltukSayisi % 4; j++)
            {
                Button koltuk = new Button();
                koltuk.Height = koltuk.Width = 40;
                koltuk.Top = 30 + ((koltukSayisi / 4) * 45);
                koltuk.Left = 5 + (j * 45);
                koltuk.Text = koltukNo.ToString();
                koltuk.Click += Koltuk_Click; // Koltuk_Click adında bir olay işleyici oluşturmanız gerekiyor
                koltukNo++;
                this.Controls.Add(koltuk);
            }
        }



        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button koltuk = sender as Button;
            // Kullanıcının tıkladığı koltuğun numarasını alın
            int koltukNo = int.Parse(koltuk.Text);

            // Burada, kullanıcının seçtiği koltukla ilgili işlemleri gerçekleştirebilirsiniz
            // Örneğin, koltuğu rezerve edebilir veya kullanıcıya bir mesaj gösterebilirsiniz
            MessageBox.Show("Koltuk " + koltukNo + " seçildi!");
        }


        private void bttnKayit_Click(object sender, EventArgs e)
        {

        }
    }
}
