using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace prolab2_projeee
{
    public partial class Kayit_formu : Form
    {

        public string KoltukSayisi { get; set; }

        public int SecilenKoltukNo { get; set; }

        List<Customer> yolcular = new List<Customer>();

        public Kayit_formu(string koltuk_sayisi)
        {
            InitializeComponent();

            //this.KoltukSayisi = koltukSayisi;
            int sira = int.Parse(koltuk_sayisi);

            KoltukDoldur(sira );

            RezerveKoltuklar();

        }


        void KoltukDoldur(int koltukSayisi)
        {
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
                    koltuk.Click += Koltuk_Click; 
                    koltukNo++;
                    this.Controls.Add(koltuk);
                }
            }

            for (int j = 0; j < koltukSayisi % 4; j++)
            {
                Button koltuk = new Button();
                koltuk.Height = koltuk.Width = 40;
                koltuk.Top = 30 + ((koltukSayisi / 4) * 45);
                koltuk.Left = 5 + (j * 45);
                koltuk.Text = koltukNo.ToString();
                koltuk.Click += Koltuk_Click;  
                koltukNo++;
                this.Controls.Add(koltuk);
            }
        }



        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button koltuk = sender as Button;
            int koltukNo = int.Parse(koltuk.Text);

            SecilenKoltukNo = koltukNo;

            if (koltuk.BackColor == Color.Red || koltuk.BackColor == Color.Green)
            {
                MessageBox.Show("Koltuk " + koltukNo + " rezerve edilmiş durumda ve seçilemez!");
            }
            else
            {
                koltuk.BackColor = Color.Green;
                MessageBox.Show("Koltuk " + koltukNo + " seçildi!");
            }
        }


        private void bttnKayit_Click(object sender, EventArgs e)
        {
            Customer yeniYolcu = new Customer();
            yeniYolcu.Ad = txtYolcuAd.Text;
            yeniYolcu.Soyad = yolcuSoyadTxt.Text;
            yeniYolcu.TcNumara = TcNumaraTxt.Text;
            yeniYolcu.DogumTarihi = dateTimePicker1.Value.Date;
            yeniYolcu.KoltukNo = SecilenKoltukNo;

            yolcular.Add(yeniYolcu);

            UpdateDataGridView();

            MessageBox.Show("Bilgiler kaydedildi!\n" + yeniYolcu.Ad + " yolcuSoydı : " + yeniYolcu.Soyad + "TC numarası : " + yeniYolcu.TcNumara + "yolcunun doğum tarihi : " + yeniYolcu.DogumTarihi + " ve yocunun koltuk numarası " + yeniYolcu.KoltukNo);
        }




        private void Kayit_formu_Load(object sender, EventArgs e)
        {

        }

        private void txtYolcuAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void yolcuSoyadTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TcNumaraTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void RezerveKoltuklar()
        {
            Random random = new Random();
            List<int> bosKoltuklar = new List<int>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.BackColor != Color.Red && ctrl.Text != "Kaydet")
                {
                    bosKoltuklar.Add(int.Parse(ctrl.Text));
                }
            }

            int koltukSayisi = bosKoltuklar.Count;
            int rezerveEdilecekKoltukSayisi = koltukSayisi / 2;  

            for (int i = 0; i < rezerveEdilecekKoltukSayisi; i++)
            {
                int index = random.Next(0, koltukSayisi);
                int koltukNo = bosKoltuklar[index];

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button && ctrl.Text == koltukNo.ToString())
                    {
                        ctrl.BackColor = Color.Red;
                        break;
                    }
                }

                bosKoltuklar.RemoveAt(index);
                koltukSayisi--;
            }
        }


        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (Customer yolcu in yolcular)
            {
                dataGridView1.Rows.Add(yolcu.Ad, yolcu.Soyad, yolcu.TcNumara, yolcu.DogumTarihi.ToString(), yolcu.KoltukNo);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string yolcuAdi = txtYolcuAd.Text;
            string yolcuSoyad = yolcuSoyadTxt.Text;
            int yolcuTc = int.Parse(TcNumaraTxt.Text);
            string yolcuTcnumarasi = (yolcuTc).ToString();
            DateTime dogumTarih = dateTimePicker1.Value;

            string yolcuDogumTarihi = dogumTarih.ToString();

            dataGridView1.Rows.Add(yolcuAdi, yolcuSoyad, yolcuTcnumarasi, yolcuDogumTarihi);
        }
    }
}
