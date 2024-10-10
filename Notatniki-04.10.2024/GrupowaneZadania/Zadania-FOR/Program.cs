using System;

namespace Zadania_FOR
{
    internal class Program
    {
        // 1. Suma liczb: Napisz program, który oblicza sumę wszystkich liczb od 1 do 100 przy użyciu pętli for.
        static void Zad1()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine($"Suma liczb od 1 do 100: {sum}");
        }

        // 2. Napisz program, który tworzy tablicę jednowymiarową o długości 10, wypełnia ją liczbami od 1 do 10, a następnie wypisuje te liczby.
        static void Zad2()
        {
            int[] tab = new int[10];
            for (int i = 1; i <= tab.Length; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        // 3. Napisz program, który wczytuje 5 liczb do tablicy i mnoży każdą z nich przez 2, a następnie wypisuje wyniki.
        static void Zad3()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }
            Console.Write("Wyniki: ");
            foreach (var num in array)
                Console.Write($"{num} ");
            Console.WriteLine();
        }

        // 4. Tablica odwrotna: Napisz program, który tworzy tablicę z 10 liczbami, a następnie wypisuje je w odwrotnej kolejności.
        static void Zad4()
        {
            int[] liczby = new int[10];

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = i + 1;
            }

            for (int i = liczby.Length - 1; i >= 0; i--)
            {
                Console.Write($"{liczby[i]} ");
            }
        }

        // 5. Funkcja silni: Napisz program, który oblicza silnię liczby podanej przez użytkownika przy użyciu pętli for.
        static void Zad5(long n)
        {
            if (n < 0)
            {
                Console.WriteLine("Silnia nie jest dla liczb ujemnych.");
                return;
            }

            long silnia = 1;
            for (long i = 2; i <= n; i++)
                silnia *= i;
            Console.WriteLine($"Silnia z {n} wynosi {silnia}.");
        }

        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
            Zad4();
            Console.Write("\nPodaj Liczbę do obliczenia silni (Zad5): ");
            if (long.TryParse(Console.ReadLine(), out long n))
                Zad5(n);
            else
                Console.WriteLine("Proszę wpisać poprawną liczbę.");
        }
    }
}
