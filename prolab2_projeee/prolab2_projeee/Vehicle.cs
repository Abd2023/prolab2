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
    }

    public class Bus : Vehicle
    {
        // Otobüse ait özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
    }

    public class Train : Vehicle
    {
        // Trene ait özel özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
    }

    public class Airplane : Vehicle
    {
        // Uçağa özel özellikler burada tanımlanır
        // Gerekirse, Vehicle classından metotlar override edilir
    }
}
