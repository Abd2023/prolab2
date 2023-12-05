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
    public partial class FirmaPaneli : Form
    {

        // seferleri tutmak icin bir list olusturalim
        List<Trip> tripList = new List<Trip>();

        //araclari tutmak icin bir list olusturalim
        List<Bus> buses = new List<Bus>();
        List<Train> trainList = new List<Train>();
        List<Airplane> airplanes = new List<Airplane>();

        // giris yapilan firmanin adi

        public string girisyapilanfirmaadi = firmapanelinegirispaneli.Firma_Adi;

        public FirmaPaneli()
        {
            InitializeComponent();

            // Trip adli classimizdan nesneleri olusturalim
            // Trip trip = new Trip("demiryolu", "Istanbul - Kocaeli - Bilecik - Eski¸sehir - Ankara",);

            //araclari olusturalim
            Bus bus1 = new Bus("A", "otobus1", "benzin", "20", "3.sefer");
            Bus bus2 = new Bus("A", "otobus2", "benzin", "15", "3.sefer");
            Bus bus3 = new Bus("B", "otobus1", "benzin", "15", "3.sefer");
            Bus bus4 = new Bus("B", "otobus2", "benzin", "20", "4.sefer");
            Bus bus5 = new Bus("C", "otobus1", "benzin", "20", "4.sefer");

            // listlere ekleme yapalim 

            buses.Add(bus1);
            buses.Add(bus2);
            buses.Add(bus3);
            buses.Add(bus4);
            buses.Add(bus5);



            Train train1 = new Train("D", "tren1", "elektrik", "25", "1.sefer");
            Train train2 = new Train("D", "tren2", "elektrik", "25", "2.sefer");
            Train train3 = new Train("D", "tren3", "elektrik", "25", "2.sefer");

            // list e ekleme
            trainList.Add(train1);
            trainList.Add(train2);
            trainList.Add(train3);


            Airplane airplane1 = new Airplane("C", "ucak1", "gaz", "30", "5.sefer");
            Airplane airplane2 = new Airplane("C", "ucak2", "gaz", "30", "5.sefer");
            Airplane airplane3 = new Airplane("F", "ucak1", "gaz", "30", "6.sefer");
            Airplane airplane4 = new Airplane("F", "ucak2", "gaz", "30", "6.sefer");

            // liste ekleme
            airplanes.Add(airplane1);
            airplanes.Add(airplane2);
            airplanes.Add(airplane3);
            airplanes.Add(airplane4);

            // sefer olusturalim
            Trip trip1 = new Trip();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (girisyapilanfirmaadi == "A")
            {
                dataGridView1.Rows.Add("Otobus1", "otobus", "benzin", "20", "3.sefer");
                dataGridView1.Rows.Add("Otobus2", "otobus", "benzin", "15", "3.sefer");

            }
            else if (girisyapilanfirmaadi == "B")
            {
                dataGridView1.Rows.Add("otobus1", "otobus", "motorin", "15", "3.sefer");
                dataGridView1.Rows.Add("otobus2", "otobus", "motorin", "20", "4.sefer");


            }
            else if (girisyapilanfirmaadi == "C")
            {
                dataGridView1.Rows.Add("otobus1", "otobus", "motorin", "20", "4.sefer");
                dataGridView1.Rows.Add("ucak1", "ucak", "gaz", "30", "5.sefer");
                dataGridView1.Rows.Add("ucak2", "ucak", "gaz", "30", "5.sefer");

            }
            else if (girisyapilanfirmaadi == "D")
            {
                dataGridView1.Rows.Add("tren1", "tren", "elektrik", "25", "1.sefer");
                dataGridView1.Rows.Add("tren2", "tren", "elektrik", "25", "2.sefer");
                dataGridView1.Rows.Add("tren3", "tren", "elektrik", "25", "2.sefer");

            }
            else if (girisyapilanfirmaadi == "F")
            {
                dataGridView1.Rows.Add("ucak1", "ucak", "gaz", "30", "6.sefer");
                dataGridView1.Rows.Add("ucak2", "ucak", "gaz", "30", "6.sefer");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aracid = textBox1.Text;
            string aractipi = comboBox2.Text;
            string yakitturu = comboBox1.Text;
            string kapasite = comboBox3.Text;
            string seferno = comboBox7.Text;

            dataGridView1.Rows.Add(aracid, aractipi, yakitturu, kapasite, seferno);

            if (aractipi == "Otobus")
            {
                Bus bus = new Bus(girisyapilanfirmaadi, aracid, aractipi, kapasite, seferno);
                buses.Add(bus);
            }
            else if (aractipi == "Tren")
            {
                Train train = new Train(girisyapilanfirmaadi, aracid, aractipi, kapasite, seferno);
                trainList.Add(train);

            }
            else if (aractipi == "Ucak")
            {
                Airplane airplane = new Airplane(girisyapilanfirmaadi, aracid, aractipi, kapasite, seferno);
                airplanes.Add(airplane);
            }


            MessageBox.Show("arac eklendi.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


            MessageBox.Show("arac silindi..");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string aracid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string aractipi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string yakitturu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string kapasite = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string seferno = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            textBox1.Text = aracid;
            comboBox2.Text = aractipi;
            comboBox1.Text = yakitturu;
            comboBox3.Text = kapasite;
            comboBox7.Text = seferno;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string aracturu = comboBox4.Text;
            string guzergah = comboBox5.Text;
            string zaman = comboBox6.Text;
            string fiyat = textBox2.Text;
            // string seferno=comboBox7.Text;

            dataGridView2.Rows.Add(aracturu, guzergah, zaman, fiyat);

            Trip trip = new Trip(girisyapilanfirmaadi, aracturu, guzergah, zaman, fiyat);



            MessageBox.Show("sefer eklendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            MessageBox.Show("sefer silindi..");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string aracturu = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string guzergah = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string zaman = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string fiyat = dataGridView2.CurrentRow.Cells[3].Value.ToString();

            comboBox4.Text = aracturu;
            comboBox5.Text = guzergah;
            comboBox6.Text = zaman;
            textBox2.Text = fiyat;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isciUcretleritoplami=0;
            int yakitgideri = 0;
            int hizmetbedeli = 1000;
            int toplamGider = 0;
            

            if(girisyapilanfirmaadi=="A")
            {
                isciUcretleritoplami = 7000*2*2;
                yakitgideri = 500 * 10 * 2;
                toplamGider=isciUcretleritoplami+yakitgideri+hizmetbedeli;


            }
            else if(girisyapilanfirmaadi == "B") 
            {
                isciUcretleritoplami = 4500*2*2;
                yakitgideri = 500 * 5 * 2;
                toplamGider = isciUcretleritoplami + yakitgideri + hizmetbedeli;

            }
            else if (girisyapilanfirmaadi=="C") 
            {
                isciUcretleritoplami = (6000*2)+(16000*2*2);
                yakitgideri = (600 * 6) + (300 * 25) * 2;
                toplamGider = isciUcretleritoplami + yakitgideri + hizmetbedeli;

            }
            else if (girisyapilanfirmaadi == "D")
            {
                isciUcretleritoplami = 3000*2*3;
                yakitgideri = (375 * 3) + (450*3*2);
                toplamGider = isciUcretleritoplami + yakitgideri + hizmetbedeli;

            }
            else if (girisyapilanfirmaadi =="F")
            {
                isciUcretleritoplami = 11500*2*2;
                yakitgideri = (250 * 20 * 2);
                toplamGider = isciUcretleritoplami + yakitgideri + hizmetbedeli;

            }


            RastgeleYolcuHesabi rastgeleYolcuHesabi = new RastgeleYolcuHesabi();
            int abdullah1 = rastgeleYolcuHesabi.Toplambiletsatisi();
            dataGridView3.Rows.Add( abdullah1,isciUcretleritoplami.ToString() , yakitgideri.ToString(),hizmetbedeli,toplamGider,abdullah1-toplamGider);

            





        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }
    }
}
