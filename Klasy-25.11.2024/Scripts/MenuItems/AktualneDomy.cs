using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasy_25._11._2024.Class;
using Klasy_25._11._2024.Class.House;
using Klasy_25._11._2024.Scripts.MenuItems.Cars;
using Klasy_25._11._2024.Scripts.MenuItems.Houses;

namespace Klasy_25._11._2024.Scripts.MenuItems
{
    public class AktualneDomy
    {
        public static void MenuAktualneDomy()
        {

            bool menuWybor = true;

            while (menuWybor)
            {
                var HouseList = Domy.GetHouseList();
                var ZakupionyDomki = HouseList.Where(a => a.CzyKupiony).ToList();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    "======================================\n" +
                    "Menu AktualneTwojeMieszkania" +
                    "\n======================================\n");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Cyan;

                // Sprawdzanie dostępnych mieszkań
                for (int i = 0; i < HouseList.Count; i++)
                {
                    if (HouseList[i].CzyKupiony)
                    {
                        string garazInfo = HouseList[i].Garaz != null ? HouseList[i].Garaz.ToString() : "Brak garażu";
                        Console.WriteLine(
                             $"{i + 1}. {HouseList[i].Adres}, {HouseList[i].LiczbaPokoi} pokoje, {HouseList[i].Powierzchnia}m², " +
                             $"Czy jest kupiony: {(HouseList[i].CzyKupiony ? "Tak" : "Nie")}, Garaż: {garazInfo}");

                        if (HouseList[i].Garaz != null && HouseList[i].Garaz.Auta.Any())
                        {
                            Console.WriteLine("   Auta w garażu:");
                            foreach (var auto in HouseList[i].Garaz.Auta)
                            {
                                Console.WriteLine($"      - {auto.Marka} {auto.Model} ({auto.Kolor})");
                            }
                        }
                        else if (HouseList[i].Garaz != null)
                        {
                            Console.WriteLine("   Garaż jest pusty.");
                        }
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.ResetColor();
                    }

                }

                Console.WriteLine();

                Console.ResetColor();


                // Opcje menu
                Console.WriteLine("1. Dodaj Auta do Garażu");
                Console.WriteLine("2. Usuń Auto z Garażu");
                Console.WriteLine("3. Usuń Auta z Garażu");
                Console.WriteLine("4. Sprzedaj Mieszkanie");
                Console.WriteLine("5. Powrót do menu\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Wybierz opcję: ");
                Console.ResetColor();

                if (!int.TryParse(Console.ReadLine(), out int wybor) || wybor < 1 || wybor > 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny wybór. Wybierz opcję w zakresie od 1 do 5.");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                switch (wybor)
                {
                    case 1:
                        Console.Clear();
                        DodajAuto();
                        break;
                    case 2:
                        Console.Clear();
                        UsunAuto();
                        break;
                    case 3:
                        Console.Clear();
                        UsunAuta();
                        break;
                    case 4:
                        Console.Clear();
                        SprzedajMieszkanie();
                        break;
                    case 5:
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

        private static void DodajAuto()
        {
            var HouseList = Domy.GetHouseList();
            var ZakupionyDomki = HouseList.Where(a => a.CzyKupiony && a.Garaz != null).ToList();
            var CarsList = Auta.GetCarsList();

            if (ZakupionyDomki.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz żadnych zakupionych mieszkań.");
                Console.ResetColor();
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
                return;
            } 

            // Wyświetlanie zakupionych domów
            Console.WriteLine("Wybierz zakupiony dom, do którego chcesz dodać auto:");
            for (int i = 0; i < ZakupionyDomki.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ZakupionyDomki[i].Adres}");
            }

            Console.Write("\nWybierz numer domu: \n");
            if (int.TryParse(Console.ReadLine(), out int numerDomu) && numerDomu >= 1 && numerDomu <= ZakupionyDomki.Count)
            {
                Dom wybranyDom = ZakupionyDomki[numerDomu - 1];

                // Sprawdzenie, wybranydom ma garaż
                if (wybranyDom.Garaz.MaksymalnaLiczbaAut > wybranyDom.Garaz.Auta.Count)
                {
                    Console.WriteLine("\nWybierz auto do dodania:\n");
                    for (int i = 0; i < CarsList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {CarsList[i].Marka} {CarsList[i].Model} ({CarsList[i].Kolor})");
                    }

                    Console.Write("\nWybierz numer auta: ");
                    if (int.TryParse(Console.ReadLine(), out int numerAuta) && numerAuta >= 1 && numerAuta <= CarsList.Count)
                    {
                        Auto wybraneAuto = CarsList[numerAuta - 1];
                        wybranyDom.Garaz.DodajAuto(wybraneAuto);

                        Console.ForegroundColor = ConsoleColor.Green; // ustawia sie tekst koloru
                        Console.WriteLine($"\nAuto {wybraneAuto.Marka} {wybraneAuto.Model} zostało dodane do garażu w mieszkaniu o adresie {wybranyDom.Adres}.");
                        Console.ResetColor(); 

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Niepoprawny wybór auta.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ten garaż jest pełny.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawny wybór domu.");
                Console.ResetColor();
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();
        }

        private static void UsunAuto()
        {
             var HouseList = Domy.GetHouseList();
             var ZakupionyDomki = HouseList.Where(a => a.CzyKupiony && a.Garaz != null).ToList();
             var CarsList = Auta.GetCarsList();

             if (ZakupionyDomki.Count == 0)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Nie masz żadnych zakupionych mieszkań || Nie posiadasz domów z garażem.");
                 Console.ResetColor();
                 Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                 Console.ReadKey();
                 return;
             }

             // Wyświetlanie zakupionych domów
             Console.WriteLine("Wybierz zakupiony dom, do którego chcesz usunąć auto z garażu:");
             for (int i = 0; i < ZakupionyDomki.Count; i++)
             {
                Console.WriteLine($"{i + 1}. {ZakupionyDomki[i].Adres}");
             }

            Console.Write("\nWybierz numer domu: \n");
            if (int.TryParse(Console.ReadLine(), out int numerDomu) && numerDomu >= 1 && numerDomu <= ZakupionyDomki.Count)
            {
                Dom wybranyDom = ZakupionyDomki[numerDomu - 1];

                if (wybranyDom.Garaz.Auta.Count != 0)
                {
                    Console.WriteLine("\nWybierz auto do usunięcie:\n");
                    
                    for(int i = 0; i < wybranyDom.Garaz.Auta.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {CarsList[i].Marka} {CarsList[i].Model} ({CarsList[i].Kolor})");
                    }

                    Console.Write("\nWybierz numer auta: ");
                    if (int.TryParse(Console.ReadLine(), out int numerAuta) && numerAuta >= 1 && numerAuta <= CarsList.Count)
                    {
                        Auto wybraneAuto = CarsList[numerAuta - 1];
                        if (wybranyDom.Garaz.UsunAuto(wybraneAuto))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nAuto {wybraneAuto.Marka} {wybraneAuto.Model} zostało usunięte z garażu w mieszkaniu o adresie {wybranyDom.Adres}.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("\nNie znaleziono auta");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Niepoprawny wybór auta.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nnie ma aut do usunięcia.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawny wybór domu.");
                Console.ResetColor();
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();
         }

        private static void UsunAuta()
        {
            var HouseList = Domy.GetHouseList();
            var ZakupionyDomki = HouseList.Where(a => a.CzyKupiony && a.Garaz != null).ToList();
            var CarsList = Auta.GetCarsList();

            if (ZakupionyDomki.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz żadnych zakupionych mieszkań || Nie posiadasz domów z garażem.");
                Console.ResetColor();
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
                return;
            }

            // Wyświetlanie zakupionych domów
            Console.WriteLine("Wybierz zakupiony dom, do którego chcesz usunąć wszystkie auta z garażu:");
            for (int i = 0; i < ZakupionyDomki.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ZakupionyDomki[i].Adres}");
            }

            Console.Write("\nWybierz numer domu: \n");
            if (int.TryParse(Console.ReadLine(), out int numerDomu) && numerDomu >= 1 && numerDomu <= ZakupionyDomki.Count)
            {
                Dom wybranyDom = ZakupionyDomki[numerDomu - 1];

                if (wybranyDom.Garaz.Auta.Count != 0)
                {

                    Console.ForegroundColor = ConsoleColor.Green;


                    Console.WriteLine();
                    wybranyDom.Garaz.UsunWszystkieAuta();
                    Console.WriteLine($"z domu o adresie: {wybranyDom.Adres}");

                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTen garaż jest już pusty.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawny wybór domu.");
                Console.ResetColor();
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();
        }

        private static void SprzedajMieszkanie()
        {
            var HouseList = Domy.GetHouseList();
            var ZakupionyDomki = HouseList.Where(a => a.CzyKupiony).ToList();
            var CarsList = Auta.GetCarsList();


            if (ZakupionyDomki.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz żadnych zakupionych mieszkań");
                Console.ResetColor();
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Wybierz swój dom którego chcesz sprzedać!:");
            for (int i = 0; i < ZakupionyDomki.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ZakupionyDomki[i].Adres}");
            }

            Console.Write("\nWybierz numer domu: \n");
            if (int.TryParse(Console.ReadLine(), out int numerDomu) && numerDomu >= 1 && numerDomu <= ZakupionyDomki.Count)
            {
                Dom wybranyDom = ZakupionyDomki[numerDomu - 1];

                wybranyDom.SprzedajMieszkanie();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawny wybór domu.");
                Console.ResetColor();
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
            Console.ReadKey();


        }
    }
}
