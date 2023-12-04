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
    public partial class firmapanelinegirispaneli : Form
    {

        public List<Company> sirketler = new List<Company>();

        public firmapanelinegirispaneli()
        {
            InitializeComponent();
        }

        private void firmapanelinegirispaneli_Load(object sender, EventArgs e)
        {

        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            string firmaAdi = textBox1.Text; ;
            string firmaPassword = textBox2.Text;
            /*
            sirketler.Add(new Company("A", "afirmasi"));
            sirketler.Add(new Company("B", "bfirmasi"));
            sirketler.Add(new Company("C", "cfirmasi"));
            sirketler.Add(new Company("D", "dfirmasi"));
            sirketler.Add(new Company("F", "ffirmasi"));
            */

        }
    }
}
