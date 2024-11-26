using System;
using Klasy_25._11._2024.Scripts;

namespace Klasy_25._11._2024.Scripts.MenuItems
{
    public class Dokumentacja
    {
        public static void DokumentacjaZadania()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "======================================\n" +
                "Dokumentacja Zadania Klas Dziedziczące" +
                "\n======================================\n");
            Console.ResetColor();

            Console.WriteLine(
                "* Rozbudowałem zadania z klas dziedziczących 25.11.2024 oraz częściowo z zadań klas 4.11.2024\n" +
                "* Wykorzystałem sporo lambdy w klasach, getterach i setterach, konstruktorach także w metodach\n" +
                "* Dodałem nową rzecz czyli Console.ForegroundColor = ConsoleColor.Green która ustawia kolor tekstu także ResetColor\n"
                );

            Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Naciśnij dowolny klawisz żeby wrócić do menu");

                Console.ReadKey();
               
            Console.ResetColor();

        }


    }
}
