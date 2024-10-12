using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_IF
{
    internal class Program
    {
        /* 
         * 1. Sprawdzenie liczby parzystej/nieparzystej: 
         * Napisz program, który pyta użytkownika o liczbę i sprawdza, czy jest parzysta czy nieparzysta. 
         * Wypisz odpowiedni komunikat.
        */
        static void Zad1(int number) =>
            Console.WriteLine(number % 2 == 0 ? "Liczba jest Parzysta" : "Nie jest Parzysta"); // Skrócony Zapis Funkcji
        /* 
         * 2. Wiek:
         * Napisz program, który pyta użytkownika o jego wiek i wypisuje, 
         * czy jest osobą dorosłą, czy nieletnią (18 lat jako granica). 
        */
        static void Zad2(int age)
        {
            if(age < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny");
            } else if(age >= 18)
            {
                Console.WriteLine("Pełnoletni");
            } else
            {
                Console.WriteLine("Niepełnoletni");
            }
        }
        /* 
         * 3. Porównanie dwóch liczb:
         * Napisz program, który wczytuje dwie liczby od użytkownika i wypisuje, 
         * która z nich jest większa.
        */
        static void Zad3(int num, int num2)
        {
            if (num == num2) Console.WriteLine($"Liczba 1: {num}, Liczba 2: {num2} są równe");
            else if (num > num2) Console.WriteLine($"Liczba 1: {num} jest większa od Liczba 2: {num2}");
            else Console.WriteLine($"Liczba 1: {num} jest mniejsza od Liczba 2: {num2}");
        }
        /* 
         * 4. Znak ocen:
         * Napisz program, który przyjmuje ocenę od 1 do 5 i wypisuje komunikat odpowiedni 
         * dla każdej z ocen(np. "Niedostateczny", “Dopuszczalny”,"Dostateczny", "Dobry", "Bardzo dobry", "Celujący").
        */
        static void Zad4(int grade)
        {
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczalny");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo Dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nieznana ocena");
                    break;
            }
        }
        /*
         * 5. Temperatura: 
         * Napisz program, który pyta użytkownika o temperaturę w stopniach Celsjusza i wypisuje, 
         * czy jest zimno (poniżej 0), 
         * chłodno(0-15), 
         * ciepło(15-25) 
         * czy gorąco(powyżej 25).
        */
        static void Zad5(int temp) =>
            Console.WriteLine(temp < 0 ? "zimno" : temp <= 15 ? "chłodno" : temp <= 25 ? "ciepło" : "gorąco");

        static void Main(string[] args)
        {
            // Zadanie 1
            Console.Write("Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out int number))
                /* Jeśli konwersja zwróci true to wykona funkcja zadania1
                 * a jeśli napiszemy co innego niż liczbę to zwróci false, 
                 * out int number: Umożliwia jednoczesne zadeklarowanie zmiennej number i przypisanie jej wartości, jeśli konwersja się powiedzie
                */
                Zad1(number);
            else Console.WriteLine("Proszę wpisać poprawną liczbę.");
            // Zadanie 2
            Console.Write("Podaj swój wiek: ");
            if (int.TryParse(Console.ReadLine(), out int age))
                Zad2(age);
            else Console.WriteLine("Proszę wpisać poprawny wiek.");
            // Zadanie 3
            Console.Write("Podaj pierwszą liczbę: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Podaj drugą liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                    Zad3(num1, num2);
                else Console.WriteLine("Proszę wpisać poprawną drugą liczbę.");
            }
            else
            {
                Console.WriteLine("Proszę wpisać poprawną pierwszą liczbę.");
            }

            // Zadanie 4
            Console.Write("Podaj ocenę (1-6): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
                Zad4(grade);
            else Console.WriteLine("Proszę wpisać poprawną ocenę.");

            // Zadanie 5
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
            if (int.TryParse(Console.ReadLine(), out int temp))
                Zad5(temp);
            else Console.WriteLine("Proszę wpisać poprawną temperaturę.");

            Console.ReadKey();
        }
    }
}
