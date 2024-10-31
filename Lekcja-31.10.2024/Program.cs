using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lekcja_31._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kot kot1 = new Kot("Stefan", 6, "Rudy");
            Pies Pies1 = new Pies("Piotrek", 4, "Owczarek Niemiecki");
            Krowa Krowa1 = new Krowa("Janek", 2);

            Console.WriteLine($"{kot1.PrzedstawSie()}");
            Console.WriteLine($"{Pies1.PrzedstawSie()}");
            Console.WriteLine($"{Krowa1.PrzedstawSie()}");

            Console.ReadKey();
        }
    }
}
