using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prolab2_projeee
{
    public abstract class User
    {
        protected string username;
        protected string password;
        // User classında ortak özellikler ve metotlar burada tanımlanır
    }


    


    public class Admin : User
    {



        // Admin'e özgü özellikler ve metotlar burada tanımlanır
        public List<Company> Companies { get; set; }
        // Var olan firmalar görüntülenebilir

        public void AddCompany(Company company)
        {
            // Yeni bir firma kaydı yapılabilir
        }

        public void RemoveCompany(Company company)
        {
            // Firma kaydı silinebilir
        }

        public decimal ServiceFee { get; set; }
        // Hizmet bedeli belirlenebilmelidir (Hizmet bedelinin sabit günlük bir ücret belirlenmelidir - 1000 tl) 

    }




    


    
    public class Company : User
    {

        public string name { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public decimal serviceFee { get; set; }

        public string sifre { get; set; }
       // public string  password { get; set; }
        public List<Vehicle> Vehicles { get; set; } // Araç bilgileri

        /*
        public  Company (string firmaadi , string sifre)
        {
            this.name = firmaadi;
            this.password = sifre;
        }
        */

        

        

        // Firmaya özgü işlevler burada tanımlanır
        // Gerekirse, User classından metotlar override edilir
        // Firma paneli için gerekli özellikler ve metotlar burada tanımlanır
        private List<Vehicle> vehicles; // Araç bilgileri
                                        // Araç ekleme ve çıkarma işlemleri için metotlar

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle); // Araç ekleme işlemi
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle); // Araç çıkarma işlemi
        }

        private List<Trip> trips; // Sefer bilgileri
                                  // Sefer ekleme ve çıkarma işlemleri için metotlar

        public void AddTrip(Trip trip)
        {
            // Sefer ekleme işlemi
        }

        public void RemoveTrip(Trip trip)
        {
            // Sefer çıkarma işlemi
        }

        public decimal CalculateDailyProfit()
        {
            // Günlük kar hesabı yapılır
            // Yolcu ücretleri, hizmet bedeli, personel maliyeti ve yakıt maliyeti dikkate alınarak hesaplanır

            decimal dailyProfit = 0;

            // dailyProfit hesaplama kodunuz burada olacak

            return dailyProfit;
        }

    }
    

    

    public class UserPanel : User
    {
        // Kullanıcı paneli için gerekli özellikler ve metotlar burada tanımlanır
    }


}
