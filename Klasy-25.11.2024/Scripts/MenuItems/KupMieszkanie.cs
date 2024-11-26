using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasy_25._11._2024.Class;
using Klasy_25._11._2024.Class.Garage.Types;
using Klasy_25._11._2024.Class.Garage;
using Klasy_25._11._2024.Class.House;


namespace Klasy_25._11._2024.Scripts.MenuItems
{
    public class KupMieszkanie
    {
        private static List<Dom> HouseList = new List<Dom>
    {
        new Dom("Górska 56", 4, 25.5, false, new ŚredniGaraz(null)),
        new Dom("Górska 26", 4, 25.5, false, new MałyGaraz(null)),
        new Dom("Sterlinga 2", 8, 50.0, false, new DużyGaraz(null)),
    };

        public static void MenuKupMieszkania()
        {
            bool menuWybor = true;

            while (menuWybor)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    "======================================\n" +
                    "Menu Kup-Mieszkania" +
                    "\n======================================\n");
                Console.ResetColor();

                Console.WriteLine("1. Sprawdź dostępne mieszkania do kupienia");
                Console.WriteLine("2. Powrót do menu\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Wybierz opcję: ");
                Console.ResetColor();

                if (!int.TryParse(Console.ReadLine(), out int wybor) || wybor < 1 || wybor > 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny wybór. Wybierz opcję w zakresie od 1 do 3.");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                switch (wybor)
                {
                    case 1:
                        Console.Clear();
                        SprawdźDostepneMieszkania();
                        break;
                    case 2:
                        menuWybor = false;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Wybierz opcję ponownie.");
                        break;
                }
            }
        }

        private static void SprawdźDostepneMieszkania()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dostępne mieszkania do kupienia:");
            Console.ResetColor();





            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}