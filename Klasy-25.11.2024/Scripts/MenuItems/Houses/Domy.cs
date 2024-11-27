using Klasy_25._11._2024.Class.Garage;
using Klasy_25._11._2024.Class.Garage.Types;
using Klasy_25._11._2024.Class.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Scripts.MenuItems.Houses
{
    internal class Domy
    {
        public static List<Dom> HouseList = new List<Dom>
        {
            new Dom("Górska 56", 4, 25.5, false, new ŚredniGaraz(null)),
            new Dom("Górska 26", 4, 25.5, false, new MałyGaraz(null)),
            new Dom("Sterlinga 2", 8, 50.0, false, new DużyGaraz(null)),
            new Dom("Pomorska 26", 4, 25.5, false, null),
            new Dom("Rewolucja 2", 8, 50.0, false, new DużyGaraz(null)),
        };

        public static List<Dom> GetHouseList()
        {
            return HouseList;
        }
    }
}
