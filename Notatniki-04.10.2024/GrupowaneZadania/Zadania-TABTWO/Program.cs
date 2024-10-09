using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_TABTWO
{
    internal class Program
    {
        // Zadania z użyciem tablic dwuwymiarowych
        /*  
         *  1. Suma elementów macierzy: 
         *  Napisz program, który oblicza ile jest elementów w macierzy dwuwymiarowej 
         *  oraz wypisuje tę liczbę.
        */
        static void Zad1()
        {
            int[,] array =
            {
                {1, 2, 3},
                {4, 5, 6},
            };
            Console.WriteLine($"Liczba elementów w macierzy dwuwymiarowej: {array.Length}");
        }
        /*  
         *  2. Suma elementów macierzy: 
         *  Napisz program, który tworzy dwuwymiarową tablicę 3x3, 
         *  wczytuje jej wartości od użytkownika, 
         *  a następnie oblicza sumę wszystkich elementów.
        */
        static void Zad2()
        {
            int[,] array = new int[3,3];
            int total = 0;
            Console.WriteLine("Wprowadź wartości do macierzy 3x3:");
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    total += array[i, j];

                }
            }
            Console.WriteLine($"Suma wszystkich elementów w macierzy: {total}");

        }
        /*
         * 3. Macierz trójkątna: 
         * Napisz program, który macierz 3x3 zamienia
         * w macierz trójkątną.
        */
        static void Zad3()
        {
            int[,] array =
{
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };

            Console.WriteLine($"Macierz 3x3:");
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine("\nMacierz Trójkątna:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < i)
                        Console.Write("0 ");
                    else
                        Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        /*
         * 4. Wyszukiwanie w macierzy:
         * Napisz program, który tworzy macierz 3x3, 
         * wczytuje wartości od użytkownika, a następnie pyta o wartość 
         * i wypisuje jej położenie w macierzy (wiersz, kolumna).
        */
        static void Zad4()
        {
            int[,] array = new int[3, 3];
            Console.WriteLine("Wprowadź wartości do macierzy 3x3:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    array[i, j] = int.Parse(Console.ReadLine());

            Console.Write("Podaj wartość do wyszukania: ");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (array[i, j] == target)
                    {
                        Console.WriteLine($"Znaleziono wartość {target} na pozycji ({i}, {j}).");
                        return;
                    }   
            Console.WriteLine($"Nie znaleziono wartości {target} w macierzy.");
        }
        /*  
         *  5. Tablica z ocenami: Napisz program, 
         *  który tworzy dwuwymiarową tablicę o wymiarach 5x5, 
         *  gdzie wiersze będą reprezentować uczniów, a kolumny przedmioty.
         *  Wczytaj oceny od użytkownika i oblicz średnią ocen dla każdego ucznia
        */
        static void Zad5()
        {
            const int stdCount = 5, subCount = 5;
            int[,] grades = new int[stdCount, subCount];
            double[] averages = new double[stdCount]; // Tablica na średnie oceny uczniów

            // Wprowadzanie ocen dla każdego ucznia
            for (int i = 0; i < stdCount; i++)
            {
                Console.WriteLine($"Wprowadź oceny dla ucznia {i + 1}:");
                // Wprowadzanie ocen dla pięciu przedmiotów.
                for (int j = 0; j < subCount; j++)
                {
                    Console.Write($"Ocena z przedmiotu {j + 1}: ");
                    // Wczytanie oceny od użytkownika i zapisanie do tablicy.
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
                // Obliczanie średniej ocen dla danego ucznia.
                double average = 0;
                for (int j = 0; j < subCount; j++)
                    average += grades[i, j]; // Sumowanie ocen.
                // Obliczenie średniej i zapisanie jej w tablicy averages.
                averages[i] = average / subCount;
            }
            Console.WriteLine("\n| Uczeń | Przedmiot 1 | Przedmiot 2 | Przedmiot 3 | Przedmiot 4 | Przedmiot 5 | Średnia |");
            Console.WriteLine(new string('-', 89)); // tworzy stringa - 79 razy

            // Wyświetlanie ocen i średnich dla każdego ucznia.
            for (int i = 0; i < stdCount; i++)
            {
                Console.Write($"|   {i + 1}   "); // Numer ucznia.
                for (int j = 0; j < subCount; j++)
                {
                    // Wyświetlanie ocen z wyrównaniem do lewej w kolumnach.
                    Console.Write($"|     {grades[i, j],-7} ");
                }
                // Wyświetlanie średniej z dokładnością do dwóch miejsc po przecinku.
                Console.WriteLine($"|  {averages[i]:F2}   |");
            }
            Console.WriteLine(new string('-', 89)); // tworzy stringa - 99 razy
        }

        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
            Zad4();
            Zad5();
            Console.ReadKey();
        }
    }
}
