using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2_projeee
{
    public partial class Kullanici_paneli : Form
    {
       
        
        private List<Company> companies;



        private List<Dictionary<string, int>> routesKarayolu = new List<Dictionary<string, int>>
        {
            new Dictionary<string, int> { { "İstanbul-Kocaeli", 50 }, { "İstanbul-Ankara", 300 }, { "İstanbul-Eskişehir", 150 }, { "İstanbul-Konya", 300 } },
            new Dictionary<string, int> { { "Kocaeli-İstanbul", 50 }, { "Kocaeli-Ankara", 400 }, { "Kocaeli-Eskişehir", 100 }, { "Kocaeli-Konya", 250 } },
            new Dictionary<string, int> { { "Ankara-İstanbul", 300 }, { "Ankara-Kocaeli", 400 } },
            new Dictionary<string, int> { { "Eskişehir-İstanbul", 150 }, { "Eskişehir-Kocaeli", 100 }, { "Eskişehir-Konya", 150 } },
            new Dictionary<string, int> { { "Konya-Kocaeli", 300 }, { "Konya-Ankara", 150 }, { "Konya-Eskişehir", 150 } },
        };


        private List<Dictionary<string, int>> routesDemiryolu = new List<Dictionary<string, int>>
        {
            new Dictionary<string, int> { { "İstanbul-Kocaeli", 50 }, { "İstanbul-Bilecik", 150},{ "İstanbul-Ankara", 250 }, { "İstanbul-Eskişehir", 200 }, { "İstanbul-Konya", 300 } },
            new Dictionary<string, int> { { "Kocaeli-İstanbul", 50 }, { "Kocaeli-Bilecik", 50 }, { "Kocaeli-Ankara", 200 }, { "Kocaeli-Eskişehir", 100 }, { "Kocaeli-Konya", 250 } },
            new Dictionary<string, int> { { "Bilecik-İstanbul", 150 }, { "Bilecik-Kocaeli", 50},{ "Bilecik-Ankara", 150 }, { "Bilecik-Eskişehir", 50 }, { "Bilecik-Konya", 200 } },
            new Dictionary<string, int> { { "Ankara-İstanbul", 250 }, { "Ankara-Bilecik", 150 }, { "Ankara-Kocaeli", 200 }, {"Ankara-Eskişehir", 100 } },
            new Dictionary<string, int> { { "Eskişehir-İstanbul", 200 }, { "Eskişehir-Bilecik", 50 }, { "Eskişehir-Kocaeli", 100 }, { "Eskişehir-Ankara", 100},{ "Eskişehir-Konya", 150 } },
            new Dictionary<string, int> { {"Konya-İstanbul", 300}, { "Konya-Kocaeli", 300 }, { "Konya-Bilecik", 200 }, { "Konya-Eskişehir", 150 } },
        };

        private List<Dictionary<String, int>> routesHavayolu = new List<Dictionary<string, int>>
        {
            new Dictionary<string, int> { { "İstanbul-Ankara", 1000 }, { "İstanbul-Konya", 1200 } },
            new Dictionary<string, int> { {"Ankara-İstanbul", 1000} },
            new Dictionary<string, int> { { "Konya-İstanbul", 1200} }
        };


        public Kullanici_paneli()
        {
            InitializeComponent();
            

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



        string[][] routesSefer = new string[][]
        {
            new string[] { "İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Ankara", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" },
            new string[] { "İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Konya", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" },

            new string[] { "İstanbul", "Kocaeli", "Ankara", "Kocaeli", "İstanbul", "Kocaeli", "Ankara", "Kocaeli", "İstanbul" },
            new string[] { "İstanbul", "Kocaeli", "Eskişehir", "Konya", "Eskişehir", "Kocaeli", "İstanbul" },

            new string[] {  "İstanbul", "Konya", "İstanbul" },
            new string[] { "İstanbul", "Ankara", "İstanbul" },
            // Diğer güzergahlar...
        };


        string[][] bilgiler = new string[][]
        {
            new string[] {"3", "20", "Otobüs 1", "A"},
            new string[] {"3", "15", "Otobüs 2", "A"},
            new string[] {"3", "15", "Otobüs 1", "B"},
            new string[] {"4", "20", "Otobüs 2", "B"},
            new string[] {"4", "20", "Otobüs 1", "C"},
            new string[] {"5", "30", "Uçak 1", "C"},
            new string[] {"5", "30", "Uçak 2", "C"},
            new string[] {"1", "25", "Tren 1", "D"},
            new string[] {"2", "25", "Tren 2", "D"},
            new string[] {"2", "25", "Tren 3", "D"},
            new string[] {"6", "30", "Uçak 1", "F"},
            new string[] {"6", "30", "Uçak 2", "F"},
        };


        public static string firma_adi;
        public static string firma_araci;
        public static string koltuk_sayisi;

        private void bttnBiletAra_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            
            // Kullanıcının seçtiği kalkış ve varış noktalarını alın
            string departure = NeredencomboBox.SelectedItem.ToString();
            string arrival = NereyecomboBox.SelectedItem.ToString();

            List<int> uygubSerferler = new List<int>();

            for (int i = 0; i < routesSefer.Length; i++)
            {
                for (int j = 0; j < routesSefer[i].Length; j++)
                {
                    if (routesSefer[i][j] == departure)
                    {
                        for (int k = 0; k < routesSefer[i].Length; k++)
                        {
                            if (routesSefer[i][k] == arrival)
                            {
                                if (!uygubSerferler.Contains(i + 1))
                                    uygubSerferler.Add(i + 1);
                                break;
                            }
                        }
                    }
                }

                

            }
            
        // Arama anahtarını oluşturun
        string searchKey = departure + "-" + arrival;

            // Güzergahları arayın
        int costDemiryolu = 0;
        foreach (var route in routesDemiryolu)
        {
            if (route.ContainsKey(searchKey))
            {
                // Maliyeti bulun ve kullanıcıya gösterin
                costDemiryolu = route[searchKey];
                //MessageBox.Show("Seçilen güzergahın karayolu için maliyeti: " + costKarayolu.ToString());
                //return;
            }
        }
        int costKarayolu = 0;
        foreach (var route in routesKarayolu)
        {
            if (route.ContainsKey(searchKey))
            {
                // Maliyeti bulun ve kullanıcıya gösterin
                costKarayolu = route[searchKey];
                //MessageBox.Show("Seçilen güzergahın Karayolu için maliyeti: " + cost.ToString());
                //return;
            }
        }

        int costHavayolu = 0;
        foreach (var route in routesHavayolu)
        {
            if (route.ContainsKey(searchKey))
            {
                // Maliyeti bulun ve kullanıcıya gösterin
                costHavayolu = route[searchKey];
                //MessageBox.Show("Seçilen güzergahın hava yolu için maliyeti: " + cost.ToString());
                
            }
        }


        for (int i = 0; i < bilgiler.Length; i++)
        {
            int seferNo = int.Parse(bilgiler[i][0]);
            if (uygubSerferler.Contains(seferNo))
            {
                firma_adi = bilgiler[i][3];
                firma_araci = bilgiler[i][2];
                koltuk_sayisi = bilgiler[i][1];
                if(firma_araci.Contains("Tren"))
                    dataGridView1.Rows.Add(firma_adi, firma_araci, koltuk_sayisi, costDemiryolu);
                else if(firma_araci.Contains("Otobüs"))
                    dataGridView1.Rows.Add(firma_adi, firma_araci, koltuk_sayisi, costKarayolu);
                else if(firma_araci.Contains("Uçak"))
                     dataGridView1.Rows.Add(firma_adi, firma_araci, koltuk_sayisi, costHavayolu);
                    //MessageBox.Show("Firma adi : " + bilgiler[i][3] + " firma araci : " + bilgiler[i][2] + " koltuk Sayisi : " + bilgiler[i][1]);
            }
        }

        /*
        Kayit_formu form = new Kayit_formu(koltuk_sayisi);
        form.ShowDialog();
        */


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Çift tıklanan satırdaki 'koltuk_sayisi' değerini alın
                koltuk_sayisi = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // 'koltuk_sayisi' değerini 'Kayit_formu' formuna geçirin
                Kayit_formu form = new Kayit_formu(koltuk_sayisi);
                form.ShowDialog();
            }
        }



    }



}

