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
    public partial class Kullanici_paneli : Form
    {

        private List<Dictionary<string, int>> routes = new List<Dictionary<string, int>>
        {
            new Dictionary<string, int> { { "İstanbul-Kocaeli", 50 }, { "İstanbul-Ankara", 300 }, { "İstanbul-Eskişehir", 150 }, { "İstanbul-Konya", 300 } },
            new Dictionary<string, int> { { "Kocaeli-İstanbul", 50 }, { "Kocaeli-Ankara", 400 }, { "Kocaeli-Eskişehir", 100 }, { "Kocaeli-Konya", 250 } },
            new Dictionary<string, int> { { "Ankara-İstanbul", 300 }, { "Ankara-Kocaeli", 400 } },
            new Dictionary<string, int> { { "Eskişehir-İstanbul", 150 }, { "Eskişehir-Kocaeli", 100 }, { "Eskişehir-Konya", 150 } },
            new Dictionary<string, int> { { "Konya-Kocaeli", 300 }, { "Konya-Ankara", 150 }, { "Konya-Eskişehir", 150 } },
        };
        public Kullanici_paneli()
        {
            InitializeComponent();

            // Güzergahları temsil eden bir liste oluşturun
            // Güzergahları temsil eden bir liste oluşturun
            

        }

        private void NeredencomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NereyecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bttnBiletAra_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği kalkış ve varış noktalarını alın
            string departure = NeredencomboBox.SelectedItem.ToString();
            string arrival = NereyecomboBox.SelectedItem.ToString();

            // Arama anahtarını oluşturun
            string searchKey = departure + "-" + arrival;

            // Güzergahları arayın
            foreach (var route in routes)
            {
                if (route.ContainsKey(searchKey))
                {
                    // Maliyeti bulun ve kullanıcıya gösterin
                    int cost = route[searchKey];
                    MessageBox.Show("Seçilen güzergahın maliyeti: " + cost.ToString());
                    return;
                }
            }

            // Eğer buraya kadar geldiyse, seçilen güzergah bulunamadı
            MessageBox.Show("Seçilen güzergah bulunamadı.");
        }

    }
}
