using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorytmyPodstawowe_22._11._2024
{
    internal class Program
    {
        //Zasada działania algorytmu:
        //1. Jeśli liczba podana jest mniejsza niż 2, nie jest ona liczbą pierwszą
        //2. Jeżeli liczba jest większa, bądź równa 2, algorytm sprawdza, czy dana liczba dzieli się bez
        //reszty przez jakąkolwiek liczbę w zakresie od 2 do pierwiastka kwadratowego z tej
        //liczby.Jeśli znajdzie taki dzielnik, liczba nie jest pierwsza.Jeśli nie znajdzie żadnego
        //dzielnika, oznacza to, że liczba jest pierwsza.
        static void Zad1(int a)
        {

            void LiczbaPierwsza(int a)
            {

                bool Pierwsza = true;

                if(a < 2)
                {
                    Pierwsza = false;
                }

                for(int i = 2; i < a; i++)
                {
                    if(a % i == 0)
                    {
                        Pierwsza = false;
                        break;
                    }

                }



                if(Pierwsza)
                {
                    Console.WriteLine($"{a} Jest to liczba pierwsza");
                } else
                {
                    Console.WriteLine($"{a} Nie jest to liczba pierwsza");
                }
            }

            LiczbaPierwsza(a);
        }
        //Zasada działania algorytmu:
        //1. Wejście: Dwie liczby całkowite a oraz b
        //2. Sprawdzanie: Dopóki b nie jest równe zero:
        //1. Obliczamy resztę z dzielenia a przez b
        //2. Przypisujemy wartość b do a, a resztę z dzielenia tych liczb do b
        //3. Wyjście: Kiedy b stanie się równe 0, liczba a jest największym wspólnym dzielnikiem.
        static void Zad2(int a, int b)
        {
            while(b != 0)
            {  
                    int r = a % b;
                    a = b;
                    b = r;

                if(b == 0)
                {
                    Console.WriteLine($"liczba {a} jest największym wspólnym dzielnikiem ");
                    break;
                }
            }
        }
        //Zasada działania algorytmu:
        //1. Wejście: Tekst do zaszyfrowania i klucz(liczba), który określa, o ile miejsc w alfabecie
        //przesuniemy litery.
        //2. Przesunięcie liter: Dla każdej litery w tekście, zamieniamy ją na literę, która jest przesunięta
        //o wartość klucza w alfabecie.
        //3. Obsługa końców alfabetu: Jeśli przesunięcie wykracza poza 'Z', zaczynamy od początku
        //alfabetu ('A').
        static void Zad3(string tekst, int klucz)
        {

        }
        //Zasada działania algorytmu:
        //1. Rozpocznij od dwóch pierwszych elementów
        //2. Aby obliczyć kolejne elementy, użyj wzoru wypisanego wyżej
        //3. Program przestaje liczyć dalej, kiedy osiągnie element n, który został podany przez
        //użytkownika.
        static void Zad4(int a)
        {
            int Fibo(int a)
            {
                if(a == 0)
                    return 0;
                if(a == 1)
                    return 1;

                return Fibo(a - 1) + Fibo(a - 2);
            }

            for(int i = 0; i < a; i++)
            {
                Console.Write($"{Fibo(i)} ");
            }

            Console.WriteLine();
        }
        //Zasada działania algorytmu:
        //1. Wejście: Liczba n, którą chcemy rozłożyć na czynniki pierwsze.
        //2. Algorytm dzieli n przez najmniejsze liczby pierwsze, zaczynając od 2, aż liczba n stanie się
        //równa 1. Aby zwiększyć efektywność, możemy sprawdzać podzielność tylko do pierwiastka
        //kwadratowego z liczby, ponieważ jeśli liczba ma dzielnik większy od swojego pierwiastka,
        //to drugi dzielnik musi być mniejszy.
        static void Zad5(int n)
        {
                for(int i = 2;  i < n; i++)
                {
                    if(n % i == 0)
                        n = n / i;
                        Console.Write($"{n} ");
                }
        }
        //  Zasada działania algorytmu:
        //  1. Zakładamy, że pierwszy element zbioru jest zarówno najmniejszy, jak i największy.
        //  2. Dla każdego elementu porównujemy go z bieżącym najmniejszym i największym
        //  elementem.Jeśli jest mniejszy od bieżącego najmniejszego, aktualizujemy najmniejszy
        //  element.Jeśli jest większy od bieżącego największego, aktualizujemy największy element.
        //  3. Po przetworzeniu wszystkich elementów zwracamy znalezione wartości.
        static void Zad6()
        {

        }
        //Zasada działania algorytmu
        //1. Algorytm przechodzi przez zbiór elementów i porównuje każdą parę sąsiadujących
        //elementów.
        //2. Jeśli element na lewej pozycji jest większy niż element na prawej pozycji, to zamienia je
        //miejscami.
        //3. Każda iteracja kończy się "wypchnięciem" największego(lub najmniejszego, w zależności
        //od porządku) elementu na odpowiednie miejsce.Kolejne iteracje poruszają się coraz krócej,
        //ponieważ największe elementy "osiadają" na końcu zbioru.
        //4. Proces jest powtarzany aż do momentu, gdy w trakcie jednej pełnej iteracji nie dojdzie do
        //żadnej zamiany.
        static int[] Zad7(int[] n)
        {
            int a = n.Length;

            for(int i = 0; i < a - 1; i++)
            {
                for(int j = 0; j < a - i - 1; j++) {
                    if (n[j] < n[j + 1])
                    {
                        int t = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = t;
                    }
                }
            }

            return n;
        }
        //Zasada działania algorytmu:
        //1. Algorytm przechodzi przez zbiór elementów i znajduje najmniejszy element.
        //2. Po znalezieniu najmniejszego elementu, zamienia go z pierwszym elementem w zbiorze.
        //3. Proces jest powtarzany dla pozostałej części zbioru (pomijając już posortowane elementy),
        //czyli algorytm ponownie szuka najmniejszego elementu w pozostałych elementach i
        //zamienia go z następnym w kolejności miejscem.
        //4. Algorytm kończy pracę, gdy wszystkie elementy zostaną posortowane.
        //NIE STOSUJEMY ŻADNYCH METOD SORTUJĄCYCH ELEMENTY W TABLICY!
        static void Zad8() { }
        //Zasada działania algorytmu:
        //1. Lista elementów jest podzielona na dwie części – posortowaną i nieposortowaną.Na
        //początku posortowana część składa się tylko z pierwszego elementu.
        //2. Algorytm bierze pierwszy element z nieposortowanej części i wstawia go w odpowiednie
        //miejsce w posortowanej części.
        //3. Powtarza ten proces dla każdego kolejnego elementu z nieposortowanej części, aż cała lista
        //zostanie posortowana.
        //4. Proces kończy się, gdy wszystkie elementy znajdują się w posortowanej części.
        //NIE STOSUJEMY ŻADNYCH METOD SORTUJĄCYCH ELEMENTY W TABLICY!
        static void Zad9()
        {

        }

        static void Main(string[] args)
        {
            Zad1(59);
            Zad2(75, 50);
            Zad3("TEKSTR", 3);
            Zad4(10);
            Zad5(60);
            Zad6();
            // Zadanie 7
            int[] n = { 2, 5, 6, 7, 8 };
            foreach(int i in n)
            {
                Console.Write($"{i} ");
            }
        }

    }
}
