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
    public partial class Rezervasiyon_Sistemi : Form
    {
        public Rezervasiyon_Sistemi()
        {
            InitializeComponent();
        }

        private void adminbttn_Click(object sender, EventArgs e)
        {
            Admin_paneli form = new Admin_paneli();
            //form.Show();
            form.ShowDialog();
        }

        private void kullanicibttn_Click(object sender, EventArgs e)
        {
            Kullanici_paneli form = new Kullanici_paneli();
            form.ShowDialog();
        }

        private void firmabttn_Click(object sender, EventArgs e)
        {
            firmapanelinegirispaneli firmaPaneli = new firmapanelinegirispaneli();
            firmaPaneli.Show();
        }

        private void Rezervasiyon_Sistemi_Load(object sender, EventArgs e)
        {

        }
    }
}
