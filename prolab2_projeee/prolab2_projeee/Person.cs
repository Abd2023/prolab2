using System;

namespace prolab2_projeee
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Personel : Person
    {
        public int AfirmasiTopolamOtobusOdenenUcret = 14000;
    }

    public class Passenger : Person
    {
        public bool HasReservation { get; set; }

        public void MakeReservation()
        {
            HasReservation = true;
            Console.WriteLine($"{FirstName} {LastName} has made a reservation.");
        }

        public void CancelReservation()
        {
            if (HasReservation)
            {
                HasReservation = false;
                Console.WriteLine($"{FirstName} {LastName}'s reservation has been canceled.");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} doesn't have a reservation to cancel.");
            }
        }
    }
}
