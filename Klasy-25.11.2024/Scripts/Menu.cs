using System;
using Klasy_25._11._2024.Scripts.MenuItems;

namespace Klasy_25._11._2024.Scripts
{
    public class Menu
    {
        private static string imie = "";

        public static void Interfejs()
        {
            S0();
        }

        private static void S0()
        {

            while (true)
            {
                Console.Write("Podaj swoje imię: ");
                imie = Console.ReadLine();

                if (imie != "")
                {
                    Console.WriteLine("Naciśnij dowolny klawisz, aby przejść dalej...");
                    Console.ReadKey();
                    S1();
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wpisz jakieś imie");
                Console.ResetColor();
            }

        }

        private static void S1()
        {
            Console.Clear();
            Console.WriteLine($"Witaj {imie} w panelu zarządzania mieszkaniami\n");
            ShowMenu(); 
        }

        private static void ShowMenu()
        {
            bool menuWybor = true;

            while (menuWybor)
            {
                Console.Clear(); 

                Console.ForegroundColor = ConsoleColor.Green; // Ustawia kolor tekstu na zielony
                Console.WriteLine("========================================");
                Console.WriteLine($"Witaj {imie} w Panelu Zarządzania Mieszkaniami");
                Console.WriteLine("========================================");
                Console.ResetColor(); // Resetuje kolor

                // Opcje w menu
                Console.WriteLine();
                Console.WriteLine("1. Sprawdź Twoje Aktualne Mieszkania");
                Console.WriteLine("2. Kup Mieszkanie");
                Console.WriteLine("3. Dokumentacja Zadania");
                Console.WriteLine("4. Wyjście");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow; // Ustawiamy na żółty
                Console.Write("Wybierz opcję: ");
                Console.ResetColor(); // Resetujemy kolor na domyślny

                if (!int.TryParse(Console.ReadLine(), out int wybor) || wybor < 1 || wybor > 4)                
                // Ten kod sprawdza, czy to, co użytkownik wpisał, jest liczbą.
                // Jeśli tak, zapisuje ją do zmiennej, jeśli nie, wyświetla komunikat o błędzie.
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawny wybór. Wybierz opcję w zakresie od 1 do 4 ponownie..");
                    Console.ResetColor();

                    Console.ReadKey();
                }

                switch (wybor)
                {
                    case 1:
                        Console.Clear();
                        AktualneDomy.MenuAktualneDomy();
                        break;
                    case 2:
                        Console.Clear();
                        KupMieszkanie.MenuKupMieszkania();
                        break;
                    case 3:
                        Console.Clear();
                        Dokumentacja.DokumentacjaZadania();
                        break;
                    case 4:
                        Environment.Exit(0);
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
    }
}
