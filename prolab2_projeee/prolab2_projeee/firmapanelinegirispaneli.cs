using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace prolab2_projeee
{
    public partial class firmapanelinegirispaneli : Form
    {
        public List<Company> sirketler = new List<Company>();

        public static string Firma_Adi { get; private set; }  

        Company companyA = new Company { name = "A", sifre = "afirmasi" };
        Company companyB = new Company { name = "B", sifre = "bfirmasi" };
        Company companyC = new Company { name = "C", sifre = "cfirmasi" };
        Company companyD = new Company { name = "D", sifre = "dfirmasi" };
        Company companyF = new Company { name = "F", sifre = "ffirmasi" };

        public firmapanelinegirispaneli()
        {
            InitializeComponent();
        }

        private void firmapanelinegirispaneli_Load(object sender, EventArgs e)
        {
            sirketler.Add(companyA);
            sirketler.Add(companyB);
            sirketler.Add(companyC);
            sirketler.Add(companyD);
            sirketler.Add(companyF);
        }

        //asdfasf

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            string firmaAdi = txtBoxfirmaAdi.Text; ;
            string firmaPassword = textBoxFirmaSifresi.Text;
            bool girisBasarili = false;

            foreach (Company company in sirketler)
            {
                if (firmaAdi == company.name && firmaPassword == company.sifre)
                {
                    Firma_Adi = firmaAdi;
                    MessageBox.Show("giris basarili");
                    girisBasarili = true;

                    FirmaPaneli firmaPaneli = new FirmaPaneli();
                    firmaPaneli.Show();

                    // firma paneline yonlendir
                    //Firmapanelics firmaPaneli = new Firmapanelics();
                    //firmaPaneli.Show();
                    break;
                }
            }

            if (!girisBasarili)
            {
                MessageBox.Show("Başarısız");
            }
        }

    }
}
