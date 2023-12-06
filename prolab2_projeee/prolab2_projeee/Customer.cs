using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2_projeee
{
    public class Customer
    {
        // Müşteriye ait fonksiyonlar ve classlar burada tanımlanır
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNumara { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int KoltukNo { get; set; }



        public int SeatNumber { get; set; }
        public bool IsSeatReserved { get; private set; }

        public void ReserveSeat(int seatNumber)
        {
            if (!IsSeatReserved)
            {
                SeatNumber = seatNumber;
                IsSeatReserved = true;
                Console.WriteLine($"Seat {seatNumber} has been reserved for {Ad} {Soyad}.");
            }
            else
            {
                Console.WriteLine("Seat is already reserved.");
            }
        }

        public void CancelReservation()
        {
            if (IsSeatReserved)
            {
                Console.WriteLine($"Reservation for {Ad} {Soyad} has been canceled.");
                SeatNumber = 0;
                IsSeatReserved = false;
            }
            else
            {
                Console.WriteLine("No reservation to cancel.");
            }
        }


    }
}
