using Klasy_25._11._2024.Class;
using Klasy_25._11._2024.Class.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Scripts.MenuItems.Cars
{
    public class Auta
    {
        public static List<Auto> CarsList = new List<Auto>
        {
           new Auto("Toyota", "Comollo", "Czerwony", false, "Samochód", 4, 199985),
           new Auto("Mercedes", "Kolo", "Czarny", false, "Samochód", 4, 144985),
           new Auto("Ferrari", "Camalla", "Niebieski", false, "Samochód", 4, 129985),
        };

        public static List<Auto> GetCarsList()
        {
            return CarsList;
        }
    }
}
