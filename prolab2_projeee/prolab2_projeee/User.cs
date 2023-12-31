using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prolab2_projeee
{

    public interface IProfitable
    {
        void gunlukKarhesabi();
        void genelKarhesabi();
    }

    


    public interface ILoginable
    {
        bool Login(string enteredUsername, string enteredPassword);
    }

    public abstract class User : ILoginable
    {
        protected string username;
        protected string password;

        public bool Login(string enteredUsername, string enteredPassword)
        {
            throw new NotImplementedException();
        }
    }

    public class Admin : User
    {



        public List<Company> Companies { get; set; }

        public void AddCompany(Company company)
        {
        }

        public void RemoveCompany(Company company)
        {
        }

        public decimal ServiceFee { get; set; }

    }








    public class Company : User, IProfitable, IReservable
    {
        public string name { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public decimal serviceFee { get; set; }

        public string sifre { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        private List<Vehicle> vehicles;
        private List<Trip> trips;

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public void AddTrip(Trip trip)
        {
            // Add trip logic
        }

        public void RemoveTrip(Trip trip)
        {
            // Remove trip logic
        }

        public decimal CalculateDailyProfit()
        {
            // Calculate daily profit logic
            return 0; // Placeholder, replace with actual calculation
        }

        public void gunlukKarhesabi()
        {
            // Implement the daily profit calculation logic
        }

        public void genelKarhesabi()
        {
            // Implement the general profit calculation logic
        }

        public bool IsSeatReserved { get; set; }
        public bool koltukRezerveMI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ReserveSeat()
        {
            // Implement seat reservation logic
        }

        public void CancelReservation()
        {
            // Implement seat cancellation logic
        }

        public void KoltukRezervet()
        {
            throw new NotImplementedException();
        }

        public void IptalRezervasyon()
        {
            throw new NotImplementedException();
        }
    }




    public class UserPanel : User
    {
        // Kullanıcı paneli için gerekli özellikler ve metotlar burada tanımlanır
    }


}
