using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_04._11._2024.Class
{
    // Utwórz klasę Student z następującymi właściwościami:
    // imie– (private) typ string, reprezentuje imię studenta.
    // nazwisko– (private) typ string, reprezentuje nazwisko studenta.
    // numerIndeksu– (private) typ int, reprezentuje numer indeksu
    // studenta.
    // oceny– (private) typ lista double, reprezentuje listę ocen studenta
    // Dodaj konstruktor domyślny.
    // Dodaj konstruktor, który przyjmuje Imie, Nazwisko, NumerIndeksu i
    // Oceny(lista ocen).
    //Dodaj Gettery i Settery
    // Dodaj metodę DodajOcene, która przyjmuje parametr typu int i
    // dodaje do listy ocenę.
    // Dodaj metodę SredniaOcen, która wyświetla średnią ocen studenta.
    // Dodaj metodę toString() oraz metodę Wypisz()
    public class Student
    {
        private string _imie;
        private string _nazwisko;
        private int _numerIndeksu;
        private List<double> _oceny;

        public Student()
        {
            _imie = string.Empty;
            _nazwisko = string.Empty;
            _numerIndeksu = 0;
            _oceny = new List<double>();
        }

        public Student(string imie, string nazwisko, int numerIndeksu, List<double> oceny)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _numerIndeksu = numerIndeksu;
            _oceny = oceny;
        }

        public string Imie
        {
            get => _imie;
            set => _imie = value;
        }

        public string Nazwisko
        {
            get => _nazwisko;
            set => _nazwisko = value;
        }

        public int NumerIndeksu
        {
            get => _numerIndeksu; 
            set => _numerIndeksu = value;
        }

        public List<double> Oceny
        {
            get => _oceny; 
            set => _oceny = value;
        }

        public void DodajOcene(int i)
        {
            Oceny.Add(i);
        }

        public double SredniaOcen()
        {
            double t = 0;

            for(int i = 0; i < _oceny.Count; i++)
            {
                t += Oceny[i];
            }

            return t / Oceny.Count;
        }

        public override string ToString()
        {
            return $"\nImie: {Imie}, Nazwisko: {Nazwisko}, Numer Indeksu: {NumerIndeksu}, Oceny: {string.Join(", ", Oceny)}\n";
        }

        public void Wypisz() => Console.WriteLine(ToString());

    }
}
