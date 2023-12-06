using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public class Trip
    {
        public string HangiFirma { get; set; }
        public string Aracturu { get; set; }
        public string Guzergah { get; set; }
        public string Zamani { get; set; }
        public string Fiyati { get; set; }

        public Trip()
        {

        }
        public Trip(string hangifirma, string aracturu, string guzergah, string zamani, string fiyati)
        {
            HangiFirma = hangifirma;
            Aracturu = aracturu;
            Guzergah = guzergah;
            Zamani = zamani;
            Fiyati = fiyati;
        }


    }

}
