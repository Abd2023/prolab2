using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public class Route
    {
        public string Name { get; set; }  
        public string Departure { get; set; }  
        public string Arrival { get; set; }  
        public List<string> Stops { get; set; }  
        public string TransportType { get; set; }  

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
