using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notatniki_11._10._2024
{
    internal class Program
    {
        //  1. Napisz funkcję, która przyjmuje dwie liczby jako parametry i zwraca ich sumę.
        static void Zad1(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        //  2. Napisz funkcję, która przyjmuje liczbę całkowitą i zwraca true, jeśli liczba jest
        //  parzysta, a false, jeśli nie.Podczas wywoływania tej funkcji w kodzie należy
        //  przy pomocy instrukcji warunkowej wyświetlić odpowiedni komunikat.
        static bool Zad2(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} jest to liczba parzysta");
                return true;
            }
            else
            {
                Console.WriteLine($"{a} nie jest to liczba parzysta");
                return false;
            }
        }
        //  3. Napisz funkcję, która przyjmuje liczbę N i wypisuje liczby od 1 do N. (pętla)
        static void Zad3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        //  4. Napisz funkcję, która przyjmuje trzy liczby i zwraca ich średnią. (parametry
        //  double)
        static void Zad4(double a, double b, double c)
        {
            double srednia = (a + b + c) / 3.00;
            Console.WriteLine(srednia);
        }
        //  5. Napisz funkcję, która przyjmuje dwie liczby i zwraca większą z nich.
        static void Zad5(int a, int b)
        {
            if (a > b)
                Console.WriteLine($"liczba A: {a} jest wieksza od {b}");
            else if (a < b)
                Console.WriteLine($"Liczba B: {b} jest wieksza od {a}");
            else
                Console.WriteLine($"Liczby A i B: {a}, {b} są równe");
        }
        //  6. Napisz funkcję, która sprawdza, czy liczba jest liczbą pierwszą.
        static void Zad6(int n)
        {
            bool LiczbaPierwsza = true;

            if (n <= 1)
                LiczbaPierwsza = false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    LiczbaPierwsza = false;
                    break;
                }

            }

            if (LiczbaPierwsza)
                Console.WriteLine($"{n} jest to liczba pierwsza");
            else
                Console.WriteLine($"{n} nie jest to liczba pierwsza");
        }
        //  7. Napisz funkcję, która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
        static int Zad7(int[] tab)
        {
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            return suma;
        }
        //  8. Napisz funkcję, która sprawdza, czy dany string jest palindromem.
        static void Zad8(string text)
        {
            int l = text.Length;
            for (int i = 0; i < l; i++)
            {
                // radar = radar jest palindromem tak samo jak słowo kajak
                // test = tset jest nie jest palindromem
                // jeśli znajdzie różnice to zwróci komunikat odpowiedni że nie jest
                if (text[i] != text[l - i - 1])
                {
                    Console.WriteLine("Nie jest Palindromem");
                    return;
                }
            }
            Console.WriteLine("Jest Palindromem");
        }
        //  9. Napisz funkcję, która zwraca N-tą liczbę w ciągu Fibonacciego.
        //  (REKURENCJA) WZOR Nazwa_Funkcji(a-1)+Nazwa_Funkcji(a-2)
        static int Zad9(int n)
        {
            int Fibo(int a)
            {
                if(a == 0)
                    return 0;
                if(a == 1)
                    return 1;
                return Fibo(a - 1) + Fibo(a - 2);
            }
            return Fibo(n);
        }
        //  10. Napisz funkcję, która przyjmuje tablicę liczb całkowitych i zwraca ich średnią
        //  arytmetyczną.
        static int Zad10(int[] array)
        {
            int suma = 0;
            for(int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            return suma / array.Length;
        }
        //  11. Napisz funkcję, która przyjmuje string i znak, a następnie zwraca liczbę jego
        //  wystąpień w stringu.
        static int Zad11(string text, char chars)
        {
            int count = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == chars)
                {
                    count++;
                }
            }

            Console.WriteLine($"Liczba wystąpień znaku '{chars}' w stringu: {text} wynosi {count}");

            return count;
        }
        //  12. Napisz funkcję, która przyjmuje tablicę liczb całkowitych i zwraca ilość liczb nieparzystych.
        static int Zad12(int[] tabs)
        {
            int count = 0;
            for(int i = 0; i < tabs.Length; i++)
            {
                if(tabs[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Ilość liczb nieparzystych w tablicy wynosi {count}");

            return count;
        }
        //  13. Napisz funkcję, która przyjmuje podstawę i wysokość trójkąta oraz oblicza jego pole.
        static int Zad13(int podstawa, int wysokosc)
        {
            int pole = (podstawa * wysokosc) / 2;
            return pole;
        }
        //  14. Napisz funkcję, która wypisuje N liczb ciągu Fibonacciego.
        static void Zad14(int f)
        {
            for (int i = 0; i < f; i++)
            {
                Console.Write($"{Zad9(i)} ");
            }
            Console.WriteLine();
        }
        //  15. Napisz funkcję, która przyjmuje Tablicę liczb całkowitych oraz sortującą ją.
        //  (BEZ UŻYWANIA SYSTEMOWEJ METODY SORT)
        static int[] Zad15(int[] tabes)
        {
            int n = tabes.Length;
            // przechodzi przez wszystkie elementy tablicy, z wyjątkiem ostatniego
            for (int i = 0; i < n - 1; i++)
            {
                /* 
                 * porównuje sąsiednie elementy 
                 * zmniejszając zakres, ponieważ ostatnie 
                 * i elementy są już posortowane.
                */
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Sprawdzanie, czy bieżący element jest większy od następnego
                    if (tabes[j] > tabes[j + 1])
                    {
                        // Zapisanie bieżącego elementu do zmiennej pomocniczej
                        int t = tabes[j];

                        // Zamiana miejscami
                        tabes[j] = tabes[j + 1];
                        tabes[j + 1] = t;
                    }
                }
            }
            return tabes;
        }
        static void AllZads()
        {
            // ------------- Zadanie 1 ----------------
            Zad1(5, 5);
            // ------------- Zadanie 2 ----------------
            Zad2(4);
            // ------------- Zadanie 3 ----------------
            Zad3(5);
            // ------------- Zadanie 4 ----------------
            Zad4(6, 6, 5);
            // ------------- Zadanie 5 ----------------
            Zad5(10, 5);
            // ------------- Zadanie 6 ----------------
            Zad6(2);
            // ------------- Zadanie 7 ----------------
            int[] tab = { 0, 1, 2, 3, 4 };
            int suma = Zad7(tab);
            Console.WriteLine(suma);
            // ------------- Zadanie 8 ----------------
            Zad8("kajak");
            // ------------- Zadanie 9 ----------------
            int n = 10; // N-ta liczba Fibonacciego
            int w = Zad9(n);
            Console.WriteLine($"N-ta liczba w ciągu Fibonacciego dla N = {n} to: {w}");
            // ------------- Zadanie 10 ----------------
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int wynik = Zad10(array);
            Console.WriteLine(wynik);
            // ------------- Zadanie 11 ----------------
            Zad11("testowy", 't');
            // ------------- Zadanie 12 ----------------
            int[] tab2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int tabs = Zad12(tab2);
            Console.WriteLine(tabs);
            // ------------- Zadanie 13 ----------------
            int poletrojkata = Zad13(4, 6);
            Console.WriteLine($"Pole Trójkata wynosi {poletrojkata}");
            // ------------- Zadanie 14 ----------------
            Zad14(10);
            // ------------- Zadanie 15 ----------------
            int[] tabes = { 6, 7, 9, 12, 5, 2 };
            int[] sortTabes = Zad15(tabes);
            foreach (int r in sortTabes)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            AllZads();
            Console.ReadKey();
        }
    }
}
