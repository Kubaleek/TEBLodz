namespace AlgorytmyPodstawowe_22._11._2024
{
    internal class Program
    {
        //  Zasada działania algorytmu:
        //  1. Jeśli liczba podana jest mniejsza niż 2, nie jest ona liczbą pierwszą
        //  2. Jeżeli liczba jest większa, bądź równa 2, algorytm sprawdza, czy dana liczba dzieli się bez
        //  reszty przez jakąkolwiek liczbę w zakresie od 2 do pierwiastka kwadratowego z tej
        //  liczby.Jeśli znajdzie taki dzielnik, liczba nie jest pierwsza.Jeśli nie znajdzie żadnego
        //  dzielnika, oznacza to, że liczba jest pierwsza.



        // Funkcja nic nie zwraca oraz przyjmuje parametr n o typie int
        static Action<int> Zad1 = (n) => {

            Console.WriteLine($"Zadanie 1:\n");

            if(n < 2)
            {
                Console.WriteLine("nie jest ona liczbą pierwszą\n");
            }

            for(int i = 2;  i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} nie jest liczbą pierwszą.\n");
                    return;
                }
            }

            Console.WriteLine($"{n} jest liczbą pierwszą\n");
        };

        //  Zasada działania algorytmu:
        //  1. Wejście: Dwie liczby całkowite a oraz b
        //  2. Sprawdzanie: Dopóki b nie jest równe zero:
        //  1. Obliczamy resztę z dzielenia a przez b
        //  2. Przypisujemy wartość b do a, a resztę z dzielenia tych liczb do b
        //  3. Wyjście: Kiedy b stanie się równe 0, liczba a jest największym wspólnym dzielnikiem.

        static Action<int, int> Zad2 = (a, b) =>
        {
            Console.WriteLine($"Zadanie 2:\n");

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            if (b == 0) Console.WriteLine($"liczba {a} jest największym wspólnym dzielnikiem\n");
        };

        //  Zasada działania algorytmu:
        //  1. Wejście: Tekst do zaszyfrowania i klucz(liczba), który określa, o ile miejsc w alfabecie
        //  przesuniemy litery.
        //  2. Przesunięcie liter: Dla każdej litery w tekście, zamieniamy ją na literę, która jest przesunięta
        //  o wartość klucza w alfabecie.
        //  3. Obsługa końców alfabetu: Jeśli przesunięcie wykracza poza 'Z', zaczynamy od początku
        //  alfabetu ('A').

        static Action<string, int> Zad3 = (tekst, klucz) =>
        {
            Console.WriteLine($"Zadanie 3:\n");

            string txt = "";


            // Zwraca char, przyjmuje parametry typu char z i int klucz
            Func<char, int, char> przesunZnak = (z, klucz) =>
            {
                if (char.IsUpper(z))
                    // Przesunięcie w alfabecie, uwzględniając końce alfabetu
                    return (char)((((z - 'A') + klucz) % 26) + 'A');
                else if (char.IsLower(z))
                    return (char)((((z - 'a') + klucz) % 26) + 'a');
                else
                    return z;
            };

            foreach(char z in tekst)
            {
                txt += przesunZnak(z, klucz);
            }

            Console.WriteLine($"Zaszyfrowany tekst: {txt}\n");
        };


        //  Zasada działania algorytmu:
        //  1. Rozpocznij od dwóch pierwszych elementów
        //  2. Aby obliczyć kolejne elementy, użyj wzoru wypisanego wyżej
        //  3. Program przestaje liczyć dalej, kiedy osiągnie element n, który został podany przez
        //  użytkownika.

        static Action<int> Zad4 = (a) =>
        {
            Console.WriteLine($"Zadanie 4:\n");

            static int Fibo(int a)
            {
                if (a == 0) return 0;
                if (a == 1) return 1;
                return Fibo(a - 1) + Fibo(a - 2);
            }

            for(int i = 0; i < a; i++)
            {
                Console.Write($"{Fibo(i)} ");
            }

            Console.WriteLine();
        };


        //  Zasada działania algorytmu:
        //  1. Wejście: Liczba n, którą chcemy rozłożyć na czynniki pierwsze.
        //  2. Algorytm dzieli n przez najmniejsze liczby pierwsze, zaczynając od 2, aż liczba n stanie się
        //  równa 1. Aby zwiększyć efektywność, możemy sprawdzać podzielność tylko do pierwiastka
        //  kwadratowego z liczby, ponieważ jeśli liczba ma dzielnik większy od swojego pierwiastka,
        //  to drugi dzielnik musi być mniejszy.

        static Action<int> Zad5 = (a) =>
        {
            Console.WriteLine($"\nZadanie 5:\n");

            if (a < 2)
            {
                Console.WriteLine("liczba musi być wieksza niż 1 \n");
            }

            Console.Write($"Czynniki pierwsze liczby {a} to: ");
            for (int i = 2; i < a; i++)
            {
                while(a % i == 0)
                {
                    Console.Write($"{i} ");
                    a /= i;
                }
            }
        };



        //  Zasada działania algorytmu:
        //  1. Zakładamy, że pierwszy element zbioru jest zarówno najmniejszy, jak i największy.
        //  2. Dla każdego elementu porównujemy go z bieżącym najmniejszym i największym
        //  elementem.Jeśli jest mniejszy od bieżącego najmniejszego, aktualizujemy najmniejszy
        //  element.Jeśli jest większy od bieżącego największego, aktualizujemy największy element.
        //  3. Po przetworzeniu wszystkich elementów zwracamy znalezione wartości.

        static Action<int[]> Zad6 = (n) =>
        {
            Console.WriteLine($"\n\nZadanie 6:\n");

            int min = n[0];
            int max = n[0];

            foreach (int number in n)
            {
                if(number < min)
                    min = number;
                else if(number > max)
                    max = number;
            }

            Console.WriteLine($"Najmniejszy element: {min}");
            Console.WriteLine($"Największy element: {max}");
        };

        //  Zasada działania algorytmu
        //  1. Algorytm przechodzi przez zbiór elementów i porównuje każdą parę sąsiadujących
        //  elementów.
        //  2. Jeśli element na lewej pozycji jest większy niż element na prawej pozycji, to zamienia je
        //  miejscami.
        //  3. Każda iteracja kończy się "wypchnięciem" największego(lub najmniejszego, w zależności
        //  od porządku) elementu na odpowiednie miejsce.Kolejne iteracje poruszają się coraz krócej,
        //  ponieważ największe elementy "osiadają" na końcu zbioru.
        //  4. Proces jest powtarzany aż do momentu, gdy w trakcie jednej pełnej iteracji nie dojdzie do
        //  żadnej zamiany.

        static Action<int[]> Zad7 = (n) =>
        {

            Console.WriteLine($"\nZadanie 7:\n");

            int w = n.Length;

            for(int i = 0; i < w - 1; i++)
            {
                for(int j = 0; j < w - j - 1; j++)
                {
                    if (n[j] > n[j + 1])
                    {
                        int t = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = t;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", n));
        };


        //  Zasada działania algorytmu:
        //  1. Algorytm przechodzi przez zbiór elementów i znajduje najmniejszy element.
        //  2. Po znalezieniu najmniejszego elementu, zamienia go z pierwszym elementem w zbiorze.
        //  3. Proces jest powtarzany dla pozostałej części zbioru (pomijając już posortowane elementy),
        //  czyli algorytm ponownie szuka najmniejszego elementu w pozostałych elementach i
        //  zamienia go z następnym w kolejności miejscem.
        //  4. Algorytm kończy pracę, gdy wszystkie elementy zostaną posortowane.
        //  NIE STOSUJEMY ŻADNYCH METOD SORTUJĄCYCH ELEMENTY W TABLICY!

        static Action<int[]> Zad8 = (n) =>
        {
            Console.WriteLine($"\nZadanie 8:\n");

            int w = n.Length;

            for(int i = 0; i < w - 1; i++)
            {
                int b = i;

                for(int j = 0; j < w; j++)
                {
                    if (n[j] < n[b])
                    {
                        b = j;
                    }
                }

            }

            Console.WriteLine(string.Join(", ", n));

        };

        //  Zasada działania algorytmu:
        //  1. Lista elementów jest podzielona na dwie części – posortowaną i nieposortowaną.Na
        //  początku posortowana część składa się tylko z pierwszego elementu.
        //  2. Algorytm bierze pierwszy element z nieposortowanej części i wstawia go w odpowiednie
        //  miejsce w posortowanej części.
        //  3. Powtarza ten proces dla każdego kolejnego elementu z nieposortowanej części, aż cała lista
        //  zostanie posortowana.
        //  4. Proces kończy się, gdy wszystkie elementy znajdują się w posortowanej części.
        //  NIE STOSUJEMY ŻADNYCH METOD SORTUJĄCYCH ELEMENTY W TABLICY!


        static void Main(string[] args)
        {
            Zad1(5);

            Zad2(25,5);

            Zad3("Tekst", 3);

            Zad4(10);

            Zad5(64);

            int[] n = { 12, 5, 9, 20, 4 };

            Zad6(n);

            Zad7(n);

            Zad8(n);

            // Zad 9
        }

    }
}
