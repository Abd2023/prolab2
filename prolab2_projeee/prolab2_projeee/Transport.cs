using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{

    public interface IReservable
    {
        bool koltukRezerveMI { get; set; }
        void KoltukRezervet();
        void IptalRezervasyon();
    }


    public class Transport : IReservable
    {
        public bool koltukRezerveMI { get; set; }
        

        public void KoltukRezervet()
        {
            if (!koltukRezerveMI)
            {
                // Logic to reserve the seat
                koltukRezerveMI = true;
                Console.WriteLine("Seat reserved successfully.");
            }
            else
            {
                Console.WriteLine("Seat is already reserved.");
            }
        }

        public void IptalRezervasyon()
        {
            if (koltukRezerveMI)
            {
                // Logic to cancel the reservation
                koltukRezerveMI = false;
                Console.WriteLine("Reservation canceled successfully.");
            }
            else
            {
                Console.WriteLine("No reservation to cancel.");
            }
        }
    }

}
