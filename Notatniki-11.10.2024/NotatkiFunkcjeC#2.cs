using System.ComponentModel;

namespace FUNKCJE_C_
{
    internal class Program
    {
        static int Wyswietl(int a)
        {
            return a;
        }
        static string Wyswietl(string a)
        {
            return a;
        }
        static double Wyswietl(double a)
        {
            return a;
        }
        static int Nazwa(int a, int b)
        {
            int c = a + b;
            //return a+b;
            return c;
        }
        static void WypiszStringIng(string a, int b)
        {
            Console.WriteLine(a + b);
        }
        static bool PrawdaFalsz(int a,  int b)
        {
            return a > b;
            //return a == b;
            //return a < b;
        }
        static void Wypisz(string s)
        {
            Console.WriteLine(s);
        }
        static int[] dodaj(int []tab)
        {
            for (int i = 0; i < tab.Length; i++){
                tab[i] += 1;
            }
            return tab;
        }
        static int[] dodaj2(int[] tab)
        {
            int[] array = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                array[i] += 1;
            }
            return array;
        }
        static void wypiszTablice(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static int WypiszInt(int a=0)
        {
            return a;
        }
        static int wynik(int a)
        {
            return a;
        }
        static int wynik(int a, int b)
        {
            return a+b;
        }
        static int wynik(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 5, e=7;
            string s = "Witam";
            double d = 6.5;
            const int n = 5;
            int [] tab = new int[n];
            Console.WriteLine(Wyswietl(a));
            int c = Wyswietl(a);
            Console.WriteLine("C = "+c);
            Console.WriteLine(Wyswietl(s));
            Console.WriteLine(Wyswietl(d));
            Console.WriteLine("Wynik="+Nazwa(a, b));
            Console.WriteLine(PrawdaFalsz(a, b));
            Wypisz(s);
            int[] tab2 = new int[n];
            Console.WriteLine("Tab2 zera");
            wypiszTablice(tab2);
            //tab2 = dodaj(tab);
            tab2 = dodaj2(tab);
            Console.WriteLine("Tab jedynki");
            wypiszTablice(tab);
            Console.WriteLine("Tab2 jedynki");
            wypiszTablice(tab2);
            Console.WriteLine(WypiszInt(a));
            Console.WriteLine(WypiszInt(a+3));
            Console.WriteLine(WypiszInt());
            Console.WriteLine(WypiszInt(wynik(a)));
            Console.WriteLine(WypiszInt(wynik(a,b)));
            Console.WriteLine(WypiszInt(wynik(a,b,e)));
        }
    }
}
