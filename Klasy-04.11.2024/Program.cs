using Klasy_04._11._2024.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_04._11._2024
{
    internal class Program
    {

       static void Interfejs()
       {
            string name = "";
            Auto Toyota = new Auto("Toyota", "Corolla", 1995, 30);
            Dom Domek = new Dom("Sienkiewicza", 8, 5.5, true);
            Student Student = new Student("Adam", "Kowalski", 1, new List<double>() {1, 1, 5, 5, 3});

            void OneStage()
            {
                Console.WriteLine("====== 1/2 Etapu ======");
                Console.WriteLine("Cześć podaj swoje imie...");

                name = Console.ReadLine();

                Console.WriteLine($"\nWitaj {name}!\n");
                Console.WriteLine($"Naciśnij dowolny klawisz żeby przejść 2/2 etapu");

                Console.WriteLine("==============");

                Console.ReadKey();

                TwoStage();
            }

            void TwoStage()
            {
                Console.Clear();
                Console.WriteLine("====== 2/2 Etapu ======");
                Console.WriteLine($"{name}, zapraszam Ciebie do mojego rozbudowanego interfejsu,");
                Console.WriteLine("na którym będzie można zobaczyć działanie różnych klas:");
                Console.WriteLine("* Auto,\n* Student,\n* Dom,");
                Console.WriteLine("Autor: Kuba Król");

                Console.WriteLine($"\nNaciśnij dowolny klawisz żeby przejść do menu");

                Console.WriteLine("==============");

                Console.ReadKey();

                ShowMenu();
            }

            void ShowMenu()
            {
                Console.Clear();

                bool MenuWybor = true;

                while(MenuWybor)
                {
                    Console.WriteLine("====== Menu ====== ");
                    Console.WriteLine($"{name}, Wybierz z dostępnych opcji menu:");
                    Console.WriteLine($"1. Samochody \n2. Domy \n3. Studenci\n4. Wyjście");

                    Console.Write("\nPodaj swój wybór: ");
                    int MenuInput = Convert.ToInt32(Console.ReadLine());
                    switch (MenuInput)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("====== Samochody Menu ======");
                            Console.WriteLine($"Wybierz z dostępnych opcji menu:");
                            Console.WriteLine($"1. Sprawdź Informacje o Aucie \n2. Wywołaj Metodę Jazda() \n3. Powrót do Menu");

                            Console.Write("\nPodaj swój wybór: ");
                            int CarMenuInput = Convert.ToInt32(Console.ReadLine());

                            switch (CarMenuInput)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("====== Oto Aktualne Informacje o Aucie: ======");

                                    Toyota.Wypisz();

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 2:
                                    Console.Clear();

                                    Console.WriteLine("====== Wywołanie Funkcji Jazda(): ====== ");

                                    Toyota.Jazda(5);

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 3:
                                    ShowMenu();
                                    break;
                                default:
                                    Console.WriteLine("\nProszę wybrać jedną z dostępnych opcji \n");
                                    break;
                            }

                            MenuWybor = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("====== Samochody Menu ======");
                            Console.WriteLine($"Wybierz z dostępnych opcji menu:");
                            Console.WriteLine($"1. Sprawdź Informacje o Mieszkaniu \n2. Wywołaj Metodę Wynajmij() \n3. Wywołaj ZwrocDom() \n4. Powrót do Menu");

                            Console.Write("\nPodaj swój wybór: ");
                            int HouseMenuInput = Convert.ToInt32(Console.ReadLine());

                            switch (HouseMenuInput)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("====== Oto Aktualne Informacje o Domku: ======");

                                    Domek.Wypisz();

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 2:
                                    Console.Clear();

                                    Console.WriteLine("====== Wywołanie Funkcji Wynajmij(): ====== ");

                                    Domek.Wynajmij();

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 3:
                                    Console.Clear();

                                    Console.WriteLine("====== Wywołanie Funkcji ZwrocDom(): ====== ");

                                    Domek.ZwrocDom();

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                break;
                                case 4:
                                    ShowMenu();
                                    break;
                                default:
                                    Console.WriteLine("\nProszę wybrać jedną z dostępnych opcji \n");
                                    break;
                            }


                            MenuWybor = false;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("====== Studenci Menu ======");
                            Console.WriteLine($"Wybierz z dostępnych opcji menu:");
                            Console.WriteLine($"1. Sprawdź Informacje o Studencie \n2. Wywołaj Metodę DodajOcene() \n3. Wywołaj SredniaOcen() \n4. Powrót do Menu");

                            Console.Write("\nPodaj swój wybór: ");
                            int StudentMenuInput = Convert.ToInt32(Console.ReadLine());

                            switch (StudentMenuInput)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("====== Oto Aktualne Informacje o Studencie: ======");

                                    Student.Wypisz();

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 2:
                                    Console.Clear();

                                    Console.WriteLine("====== Wywołanie Funkcji DodajOcene(): ====== ");

                                    bool OcenaOutput = true;

                                    while (OcenaOutput)
                                    {
                                        Console.Write("\nPodaj ocenę: ");
                                        int OcenaInput = Convert.ToInt32(Console.ReadLine());

                                        if (OcenaInput > 0 && OcenaInput <= 6)
                                        {
                                            Student.DodajOcene(OcenaInput);

                                            Console.WriteLine($"\nDodano ocene: {OcenaInput}");
                                            Console.WriteLine($"\nAktualna lista tak wygląda {string.Join(", ", Student.Oceny)}\n");
                                            break;
                                        }
                                        else

                                        {
                                            Console.WriteLine("\nPodana ocena musi być liczbą z zakresu od 1 do 6.\n");
                                        }
                                    }

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 3:
                                    Console.Clear();

                                    Console.WriteLine("====== Wywołanie Funkcji SredniaOcen(): ====== ");

                                    Console.WriteLine($"\nAktualna średnia ocen dla studenta o imieniu: {Student.Imie} = {Student.SredniaOcen()}\n");

                                    Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                                    Console.ReadKey();

                                    ShowMenu();

                                    break;
                                case 4:
                                    ShowMenu();
                                    break;
                                default:
                                    Console.WriteLine("\nProszę wybrać jedną z dostępnych opcji \n");
                                    break;
                            }
                            MenuWybor = false;
                            break;
                        case 4:
                            Environment.Exit(0);
                        break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nProszę wybrać jedną z dostępnych opcji (1, 2 lub 3).\n");
                        break;
                    }
                }

            }

            OneStage();
       }

        static void Main(string[] args)
        {
            Interfejs();

            Console.ReadKey();
        }
    }
}
