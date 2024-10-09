using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_TABONE
{
    internal class Program
    {
        /*
         * 1. Wyszukiwanie elementu:
         * Napisz program, który wczytuje 10 liczb do tablicy i sprawdza, 
         * czy podana przez użytkownika liczba znajduje się w tej tablicy.
        */
        static void Zad1()
        {
            int[] arrays = new int[10];
            int sNumber;

            Console.WriteLine("Podaj 10 liczb:");
            for (int i = 0; i < arrays.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arrays[i]))
                {
                    Console.WriteLine("Proszę wpisać poprawną liczbę całkowitą:");
                }
            }

            Console.Write("Podaj liczbę do sprawdzenia: ");
            while (!int.TryParse(Console.ReadLine(), out sNumber))
            {
                Console.WriteLine("Proszę wpisać poprawną liczbę całkowitą:");
            }

            bool foundNumber = arrays.Contains(sNumber); // Metoda Contains sprawdza, czy zmienna sNumber znajduje się w kolekcji arrays. Zwraca ona wartość logiczną (true lub false):
            Console.WriteLine(foundNumber ? $"Liczba {sNumber} została znaleziona." : $"Liczba {sNumber} nie została znaleziona.");
        }
        /*
         * 2. Średnia z tablicy: Napisz program, 
         * który wczytuje 5 liczb do tablicy i oblicza ich średnią.
        */
        static void Zad2()
        {
            int[] arrays = { 2, 2, 3, 5, 6 };
            int sum = 0;

            for(int i = 0;i < arrays.Length;i++)
                sum += arrays[i];

            double result = (double)sum / arrays.Length;
            Console.WriteLine($"Średnia wynosi: {result}");
        }
        /* 
         * 3. Największa liczba: Napisz program, który wczytuje 10 liczb do tablicy 
         * i wypisuje największą liczbę oraz jej indeks.
        */
        static void Zad3()
        {
            int[] arrays = { 5, 7, 25, 12, 18, 15, 16, 24, 29, 45, 75 };

            int maxNumber = arrays[0];
            int maxIndex = 0;

            for (int i = 1; i < arrays.Length; i++)
                if (arrays[i] > maxNumber)
                {
                    maxNumber = arrays[i];
                    maxIndex = i;
                }

            Console.WriteLine($"Największa liczba to: {maxNumber} na indeksie {maxIndex}.");
        }
        /*
         * 4. Zliczanie wystąpień: 
         * Napisz program, który wczytuje 10 liczb do tablicy i 
         * zlicza, ile razy pojawia się każda liczba.
        */
        static void Zad4()
        {
            int[] arrays = { 5, 5, 6, 2, 4, 1, 1, 2, 2, 8, 5 };
            int[] count = new int[10];

            foreach (int number in arrays)
            {
                if (number >= 0 && number < count.Length)
                    count[number]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    Console.WriteLine($"Liczba {i} występuje {count[i]} raz(y).");
            }
        }
        /*
         * 5. Tablica kwadratów: 
         * Napisz program, który tworzy tablicę jednowymiarową z 10 liczbami 
         * i wypełnia ją kwadratami liczb od 1 do 10.
        */
        static void Zad5()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * (i + 1);
                Console.Write($"{array[i]} ");
            }
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
