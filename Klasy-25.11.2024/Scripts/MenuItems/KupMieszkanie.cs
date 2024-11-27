using System;
using System.Collections.Generic;
using System.Linq;
using Klasy_25._11._2024.Class;
using Klasy_25._11._2024.Class.Garage.Types;
using Klasy_25._11._2024.Class.Garage;
using Klasy_25._11._2024.Class.House;
using Klasy_25._11._2024.Scripts.MenuItems.Houses;

namespace Klasy_25._11._2024.Scripts.MenuItems
{
    public class KupMieszkanie
    {
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

                if (!int.TryParse(Console.ReadLine(), out int wybor) || wybor < 1 || wybor > 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny wybór. Wybierz opcję w zakresie od 1 do 2.");
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
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Niepoprawny wybór. Wybierz opcję ponownie.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static void SprawdźDostepneMieszkania()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Anulowanie Zakupu jest pod '0'");
            Console.WriteLine("Dostępne mieszkania do kupienia:\n");
            Console.ResetColor();

            var HouseList = Domy.GetHouseList();

            // Tylko dostępne (niekupione) mieszkania
            var DostepneMieszkania = HouseList.Where(h => !h.CzyKupiony).ToList();

            if (DostepneMieszkania.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Brak dostępnych mieszkań do kupienia.");
                Console.ResetColor();
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
                return;
            }

            // Wyświetlanie dostępnych mieszkań
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < DostepneMieszkania.Count; i++)
            {
                string garazInfo = DostepneMieszkania[i].Garaz != null ? DostepneMieszkania[i].Garaz.ToString() : "Brak garażu";
                Console.WriteLine(
                     $"{i + 1}. {DostepneMieszkania[i].Adres}, {DostepneMieszkania[i].LiczbaPokoi} pokoje, {DostepneMieszkania[i].Powierzchnia}m², " +
                     $"Czy jest kupiony: {(DostepneMieszkania[i].CzyKupiony ? "Tak" : "Nie")}, Garaż: {garazInfo}");
            }
            Console.ResetColor();

            bool KupMenu = true;
            while (KupMenu)
            {
                Console.Write("\nWybierz numer mieszkania, które chcesz kupić: ");
                if (int.TryParse(Console.ReadLine(), out int wybór))
                {
                    if (wybór == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zakup został anulowany.");
                        Console.ResetColor();
                        KupMenu = false;
                    }
                    else if (wybór > 0 && wybór <= DostepneMieszkania.Count)
                    {
                        // Zmieniamy stan mieszkania na kupione
                        var mieszkanieDoZakupu = DostepneMieszkania[wybór - 1];
                        mieszkanieDoZakupu.CzyKupiony = true;

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Gratulacje! Mieszkanie o adresie {mieszkanieDoZakupu.Adres} zostało pomyślnie kupione.");
                        Console.ResetColor();

                        KupMenu = false; // Zakończenie menu po udanym zakupie
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Numer mieszkania musi być w zakresie od 1 do " + DostepneMieszkania.Count);
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny wybór. Proszę podać numer mieszkania lub '0' aby anulować.");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
