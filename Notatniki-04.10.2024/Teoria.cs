namespace PODSTAWY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podstawy C#");
            
            Console.WriteLine("\nDzialania na liczbach");
            Console.WriteLine(5 - 1);

            int a = 5, b = 3;

            Console.WriteLine(a - 1);
            Console.WriteLine(a + b);
            
            string tekst = "witam";
            Console.WriteLine("\nŁancuchy");
            Console.WriteLine(tekst + a);
            Console.WriteLine(tekst.Length + a - b);
            string tekst2 = "to ja";
            Console.WriteLine(tekst + tekst2);

            //KOMENTOWANIE

            /*
              Komentowanie
            fefefe
            fefeef

            */

            
            
            //ZMIENNE
            int zm_int = 1;
            double zm_double = 2.33;
            char zm_char = 'S';
            string zm_string = "Program";
            bool zm_bool = false;
           
            Console.WriteLine("\nOperator przypisania z dodawaniem");
            Console.WriteLine(zm_double);
            //zm_double = zm_double + 3;
            zm_double += 3;
            zm_double++;
            Console.WriteLine(zm_double);
 
            //CONST
            const int zm_int2 = 5;
            //zm_int2 += 4;
            
            Console.WriteLine("\nPorownywanie zmiennych");
            Console.WriteLine(a > b); // a= 5 , b=3
            Console.WriteLine(a < b); 
          
            Console.WriteLine("\nOdczytywanie danych z klawiatury");
            Console.WriteLine("Login: ");
            string login_uzytkownika = Console.ReadLine();

            Console.WriteLine("Witaj " + login_uzytkownika);

            Console.WriteLine("Podaj swoj wiek");
            int wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masz " + wiek + " lat");
              
            Console.WriteLine("\nMath");
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Abs(-90));
            Console.WriteLine(Math.Round(3.49));
            Console.WriteLine(Math.Round(3.50));
            
            Console.WriteLine("\nMetody String");
            string tekst3 = "WiTaM KlAsE";
            Console.WriteLine(tekst3);
            Console.WriteLine(tekst3.ToUpper());
            Console.WriteLine(tekst3.ToLower());
           
            Console.WriteLine("\nKonwertowanie");
            Console.WriteLine("Podaj klase");
            int klasa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj literke klasy");
            char litera = Convert.ToChar(Console.Read());
            Console.WriteLine($"{tekst3.ToUpper()} {klasa}{litera}");
            Console.ReadLine(); // READLINE TUTAJ!!! Console.Read() zostawia na buforze \n które nastepnie czytane jest przez readline nizej
            
            Console.WriteLine("\nKazdy index stringa");
            string Rozbieranie = "Imie";
            Console.WriteLine(Rozbieranie[0]);
            Console.WriteLine(Rozbieranie[1]);
            Console.WriteLine(Rozbieranie[2]);
            Console.WriteLine(Rozbieranie[3]);

             
            Console.WriteLine("\nZnaki Ucieczki");
            Console.WriteLine("Tak mozna pisać \"Slowo\" cudzyslow");
            Console.WriteLine("Tak \' piszemy apostrof");
            Console.WriteLine("Tak mozna zapisać \\ ukośnik");
            Console.WriteLine("Nowa linia \nA ja pisze dalej tu");
            Console.WriteLine("TAB \tA ja pisze dalej tu");
            Console.WriteLine("Cofniecie \bA ja pisze dalej tu");

           
            
            //  IF(WARUNEK){
            //      ZAWARTOSC
            //  }

            int a_war = 2;
            int b_war = 3;
            
            Console.WriteLine("\nINSTRUKCJA WARUNKOWA");

            if (a_war > b_war)
            {
                Console.WriteLine(a_war + " jest wieksze od " + b_war);
            }
            else if (a_war == b_war)
            {
                Console.WriteLine($"{a_war} jest równe {b_war}");
            }
            else
            {
                Console.WriteLine($"{b_war} jest wieksze od {a_war}");
            }

            int i5 = 5;
            int i0 = 0;
            if (i5 == i5)
            {
                if (i5 > i0)
                {
                    Console.WriteLine("Udalo sie");
                }
                else
                {
                    Console.WriteLine("Nie udalo sie");
                }
            }

            Console.WriteLine("\nOPERATOR WARUNKOWY");
            string warunek = a_war > b_war ? $"{a_war} jest wieksze" : $"{b_war} jest wieksze";
            Console.WriteLine(warunek);

            
            Console.WriteLine("\nSWITCH");
            Console.WriteLine("Wpisz liczbe z zakresu 0-2");
            string x_string = Console.ReadLine();
            int x = Convert.ToInt32(x_string);

            switch (x)
            {
                case 0:
                    Console.WriteLine("Wpisales 0");
                    break;
                case 1:
                    Console.WriteLine("Wpisales 1");
                    break;
                case 2:
                    Console.WriteLine("Wpisales 2");
                    break;
                default:
                    Console.WriteLine("Wpisales liczbe z poza zakresu");
                    break;
            }
            
            Console.WriteLine("\nPetla WHILE");
            int i_while = 0;
            while (i_while < 5)
            {
                Console.WriteLine(i_while);
                i_while++;
            }
            Console.Write('\n');
            
            Console.WriteLine("\nPetla DO WHILE");
            i_while = 0;
            do
            {
                Console.WriteLine(i_while);
                i_while++;
            }
            while (i_while < 5);
            
            
            Console.WriteLine("\nPetla FOR");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("\nPetla FOR w FOR");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
            // TABLICE
            string[] Imiona = { "Dawid", "Kacper", "Tomek", "Franek" };
            int[] liczby = { 0, 1, 2, 3, 4 };



            int[] licz;
            licz = new int[5];

            for (int i = 0; i < licz.Length; i++)
            {
                licz[i] = i;
            }
            
            

            Console.WriteLine("\nPetla FOREACH");
            foreach (int i in licz)
            {
                Console.WriteLine(i);
            }
            
            
            int[,] liczby_dwuwymiarowe = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("\nTablice Dwuwymiarowe");
            for (int i = 0; i < liczby_dwuwymiarowe.GetLength(0); i++)
            {
                for (int j = 0; j < liczby_dwuwymiarowe.GetLength(1); j++)
                {
                    Console.Write(liczby_dwuwymiarowe[i, j]);
                }
                Console.WriteLine();
            
             */
        
        }
    }
}
















