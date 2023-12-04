using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public abstract class Vehicle
    {
        // Her araca ait ortak özellikler burada tanımlanır
        // Burada CalculateFuelCost() gibi gerekli metotlar kullanılır
        public string HangiFirma { get; set; }
        public string AracID { get; set; }
        public string YakitTuru { get; set; }
        public string Kapasite { get; set; }
        public string SeferNo { get; set; }

    }


    public class Otobus : Vehicle
    {
        public string Ad { get; set; }
        public int KoltukSayisi { get; set; }
        public int SeferNo { get; set; }

        public Otobus(string ad, int koltukSayisi, int seferNo)
        {
            Ad = ad;
            KoltukSayisi = koltukSayisi;
            SeferNo = seferNo;
        }
    }

    public class Bus : Vehicle
    {
        // Otobüse ait özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
        public Bus(string hangifirma, string aracid, string yakitturu, string kapasite, string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }

        public Bus(string arac, string koltukSayisi, string seferNo)
        {
            
            this.AracID = arac;
            
            this.Kapasite = koltukSayisi;
            this.SeferNo = seferNo;
        }


    }

    public class Train : Vehicle
    {
        // Trene ait özel özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
        public Train(string hangifirma, string aracid, string yakitturu, string kapasite, string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }

    }

    public class Airplane : Vehicle
    {
        // Uçağa özel özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
        public Airplane(string hangifirma, string aracid, string yakitturu, string kapasite, string seferno)
        {
            this.HangiFirma = hangifirma;
            this.AracID = aracid;
            this.YakitTuru = yakitturu;
            this.Kapasite = kapasite;
            this.SeferNo = seferno;
        }


    }
}
