using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_03._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student();
            Human human = new Human(21, "Jan", 'M');
            Student student = new Student(23, "Bob", 'M', 12, "5Z", "informatyka");

            human.Details();
            student.Details();

            House dom1 = new House("lodz", 10);
            House dom2 = new House("Wroclaw", 105);
            House dom3 = new House("Krakow", 130);
            House dom4 = new House("Gdansk", 2);
            List<House> houses = new List<House>();
            houses.Add(dom1);
            houses.Add(dom2);
            houses.Insert(0, dom3);
            houses.Insert(2, dom4);
            Console.WriteLine(houses.ToString());
            House DomTMP = houses[3];
            houses.FirstOrDefault(b => b.Address == "Wroclaw");
            houses.Select(b => b.Rooms > 5);
            foreach (House house in houses)
            {
                Console.WriteLine(house.ToString());
            }



            Building budynek1 = new Building("Warszawa");

            Console.WriteLine(budynek1.CostPerRoom(5) + "\t" + dom1.CostPerRoom(5));
        }
    }
}
