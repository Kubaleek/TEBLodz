using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_04._11._2024.Class
{
    // Utwórz klasę Dom z następującymi właściwościami:
    // adres– (private) typ string, reprezentuje adres domu.
    // liczbaPokoi– (private) typ int, reprezentuje liczbę pokoi w domu.
    // powierzchnia– (private) typ double, reprezentuje powierzchnię
    // domu wmetrach kwadratowych.
    // czyWynajmowany– (private) typ bool, wskazuje, czy dom jest
    // wynajmowany(w konstruktorze domyslnym wartosc false)
    // Dodaj Gettery i Settery
    // Dodaj konstruktor domyślny.
    // Dodaj konstruktor, który ustawia wartości adres, liczbaPokoi i
    // powierzchnia, czyWynajmowany.
    // Dodaj metodę Wynajmij, która ustawia CzyWynajmowany na true i
    // wyświetla komunikat "Dom został wynajęty."
    // Dodaj metodę ZwrocDom, która ustawia CzyWynajmowany na false
    // i wyświetla komunikat "Dom został zwrócony."
    // Dodaj metodę toString() oraz metodę Wypisz()
    public class Dom
    {
        private string _adres;
        private int _liczbaPokoi;
        private double _powierzchnia;
        private bool _czyWynajmowany;

        
        public Dom()
        {
            _adres = string.Empty;
            _liczbaPokoi = 0;
            _powierzchnia = 0.0;
            _czyWynajmowany = false;
        }

        public Dom(string adres, int liczbaPokoi, double powierzchnia, bool czyWynajmowany)
        {
            _adres = adres;
            _liczbaPokoi = liczbaPokoi;
            _powierzchnia = powierzchnia;
            _czyWynajmowany = czyWynajmowany;
        }

        public string Adres
        {
            get => _adres;
            set => _adres = value;
        }

        public int LiczbaPokoi
        {
            get => _liczbaPokoi;
            set => _liczbaPokoi = value;
        }

        public double Powierzchnia
        {
            get => _powierzchnia; 
            set => _powierzchnia = value;
        }

        public bool CzyWynajmowany
        {
            get => _czyWynajmowany; 
            set => _czyWynajmowany = value;
        }

        public void Wynajmij()
        {
            CzyWynajmowany = true;
            Console.WriteLine("\nDom został wynajęty\n");
        }

        public void ZwrocDom()
        {
            CzyWynajmowany = false;
            Console.WriteLine("\nDom został zwrócony\n");
        }

        public override string ToString()
        {
            return $"\nAdres: {Adres}, Liczba Pokoi: {LiczbaPokoi}, Powierzchnia: {Powierzchnia} m2, Czy Wynajmowany: {CzyWynajmowany}\n";
        }

        public void Wypisz() => Console.WriteLine(ToString());
    }
}
