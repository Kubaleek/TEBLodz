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
            Kot Kot = new Kot("Stefan", 6, "Rudy");
            Pies Pies = new Pies("Piotrek", 4, "Owczarek Niemiecki");
            Krowa Krowa = new Krowa("Janek", 2);


            Console.WriteLine($"" +
                $"{Kot.PrzedstawSie()} \n" +
                $"{Pies.PrzedstawSie()} \n" +
                $"{Krowa.PrzedstawSie()}"
            );



            Console.ReadKey();
        }
    }
}
