using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public class RastgeleYolcuHesabi
    {
        public int sefernumarasi { get; set; }

        int a=0, b=0, c= 0, d = 0 , e = 0, x = 0, y = 0, z = 0, t = 0, k = 0, m = 0, n = 0, p = 0, r = 0;
        
        int toplamUcret = 0;
        int biletkazanci = 0;

        public string HangiFirma = firmapanelinegirispaneli.Firma_Adi;
        
        public int Toplambiletsatisi()
        {
            if (HangiFirma == "A")
            {
                biletkazanci = sefer3Hesap(20) + sefer3Hesap(15);
               
            }
            else if(HangiFirma == "B")
            {
                biletkazanci = sefer3Hesap(15) + sefer4Hesap(20);
            }
            else if (HangiFirma == "C")
            {
                biletkazanci = sefer4Hesap(20) + sefer5Hesap(30) + sefer5Hesap(30);
            }
            else if (HangiFirma == "D")
            {
                biletkazanci = sefer1Hesap(25) + sefer2Hesap(25) + sefer2Hesap(25);
            }
            else if (HangiFirma == "F")
            {
                biletkazanci = sefer6Hesap(30) + sefer6Hesap(30);
            }


            return biletkazanci;
        }

        public int sefer1Hesap(int kapasite)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, x = 0, y = 0, z = 0, t = 0, k = 0, m = 0, n = 0, p = 0, r = 0;

            toplamUcret = 0;
            // sefer1 (demiryolu) hesabını yapar 

            Random random = new Random();
            a = random.Next(15, kapasite + 1);
            b = random.Next(0, a + 1);
            c = random.Next(0, a - b + 1);
            d = random.Next(0, a - b - c + 1);
            e = a - b - c - d;

            x = random.Next(0, kapasite - a + b + 1);
            y = random.Next(0, kapasite - a + b - c + 1);
            z = random.Next(0, kapasite - a + b - x + c - y + d + 1);
            t = x - y - z;

            k = random.Next(0, kapasite - a + b + c - x + y + 1);
            m = random.Next(0, kapasite - a + b + c - x + y - k + z + 1);
            n = k - m;

            p = random.Next(0, kapasite - a + b + c + d - x + y - k + m + 1);
            r = p;
           
            // Console.WriteLine(a+" "+b+" " +c+" "+" "+d+" "+e+" "+y+" "+z+" "+t+" "+k+ " "+m+" "+n +" "+p+ " "+r);
            
            //ist kocaeli 50,ist bilecik 150 , ist eskişehir 200 ,ist ankara 250 
            toplamUcret = toplamUcret + (50 * b) + (150 * c) + (200 * d) + (250 * e);

            // kocaeli bilecik 50 , kocaeli eskişehir 100 ,kocaeli ankara 200
            toplamUcret = toplamUcret + (y * 50) + (z * 100) + (t * 200);

            //bilecik eskişehir 50  bilecik ankara 150
            toplamUcret = toplamUcret + (m * 50) + (n * 150);

            //eskişehir ankara 100
            toplamUcret = toplamUcret + (100 * r);

            return toplamUcret;
        }

        public int sefer2Hesap(int kapasite)
        {
            toplamUcret = 0;

            Random random = new Random();
            a = random.Next(20, kapasite + 1);
            b = random.Next(0, a + 1);
            c = random.Next(0, a - b + 1);
            d = random.Next(0, a - b - c + 1);
            e = a - b - c - d;

            x = random.Next(0, kapasite - a + b + 1);
            y = random.Next(0, kapasite - a + b - c + 1);
            z = random.Next(0, kapasite - a + b - x + c - y + d + 1);
            t = x - y - z;

            k = random.Next(0, kapasite - a + b + c - x + y + 1);
            m = random.Next(0, kapasite - a + b + c - x + y - k + z + 1);
            n = k - m;

            p = random.Next(0, kapasite - a + b + c + d - x + y - k + m + 1);
            r = p;

            //ist kocaeli 50,ist bilecik 150 , ist eskişehir 200 ,ist konya 300 
            toplamUcret = toplamUcret + (50 * b) + (150 * c) + (200 * d) + (300 * e);

            // kocaeli bilecik 50 , kocaeli eskişehir 100 ,kocaeli ankara 250
            toplamUcret = toplamUcret + (y * 50) + (z * 100) + (t * 250);

            //bilecik eskişehir 50  bilecik ankara 200
            toplamUcret = toplamUcret + (m * 50) + (n * 200);

            //eskişehir ankara 150
            toplamUcret = toplamUcret + (150 * r);


            return toplamUcret;
        }

        public int sefer3Hesap(int kapasite)
        {
            toplamUcret = 0;

            Random random2 = new Random();
            a = random2.Next(15, kapasite + 1);
            b = random2.Next(0, a+1);
            c = a - b;

            x = random2.Next(0, kapasite - a + b + 1);
            y = x;

            // ist kocaeli 50 , ist ankara 300
            toplamUcret = toplamUcret + (50 * b) + (300 * c);

            //kocaeli ankara 400 
            toplamUcret = toplamUcret + (400 * y);

            return toplamUcret;
        }

        public int sefer4Hesap(int kapasite)
        {
            toplamUcret = 0;

            Random random3 = new Random();
            a = random3.Next(15, kapasite + 1);
            b = random3.Next(0, a + 1);
            c = random3.Next(0, a - b + 1);
            d = a - b - c;

            x = random3.Next(0, kapasite - a + b + 1);
            y = random3.Next(0, kapasite - a + b - x + 1);
            z = x - y;

            k = random3.Next(0, kapasite - a + b + c - x + y + 1);
            m = k;

            // ist kocaeli 50 , ist eskişehir 150 ,ist konya300
            toplamUcret = toplamUcret + (b * 50) + (c * 150) + (d * 300);

            // kocaeli eskişehir 100, kocaeli konya 250
            toplamUcret = toplamUcret + (y * 100) + (z * 250);

            // eskişehir konya 150
            toplamUcret = toplamUcret + (m * 150);


            return toplamUcret;

        }
        public int sefer5Hesap(int kapasite)
        {
            toplamUcret = 0;

            Random random4 = new Random();
            a = random4.Next(25, kapasite + 1);
            b = a;

            // ist konya 1200
            toplamUcret = toplamUcret + (b * 1200);

            return toplamUcret;
        }
        public int sefer6Hesap(int kapasite)
        {
            toplamUcret = 0;

            Random rand5 = new Random();
            a = rand5.Next(25, kapasite + 1);
            b = a;

            //ist ankara 1000
            toplamUcret = toplamUcret + (b * 1000);

            return toplamUcret;
        }

    }
}