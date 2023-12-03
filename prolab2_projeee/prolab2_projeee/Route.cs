using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public class Route
    {
        public string Name { get; set; } // Seferin adı
        public string Departure { get; set; } // Kalkış noktası
        public string Arrival { get; set; } // Varış noktası
        public List<string> Stops { get; set; } // Duraklar
        public string TransportType { get; set; } // Ulaşım türü

        public Route(string name, string departure, string arrival, List<string> stops, string transportType)
        {
            Name = name;
            Departure = departure;
            Arrival = arrival;
            Stops = stops;
            TransportType = transportType;
        }
    }









}
