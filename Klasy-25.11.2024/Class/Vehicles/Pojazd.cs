using System;

namespace Klasy_25._11._2024.Class
{
    public class Pojazd
    {
        private string _nazwa;
        private int _iloscKol;
        private int _rejestracja;

        public string Nazwa { get => _nazwa; set => _nazwa = value; }

        public int IloscKol { get => _iloscKol; set => _iloscKol = value; }

        public int Rejestracja{ get => _rejestracja; set => _rejestracja = value; }

        public Pojazd() => 
            (_nazwa, _iloscKol, _rejestracja) = (string.Empty, 0, 0);

        public Pojazd(string nazwa, int iloscKol, int rejestracja) => 
            (_nazwa, _iloscKol, _rejestracja) = (nazwa, iloscKol, rejestracja);

        public override string ToString() =>
            "----------------------\n" +
            $" Nazwa       : {Nazwa}\n" +
            $" Ilość kół   : {IloscKol}\n" +
            $" Rejestracja : {Rejestracja}";
        public virtual void Wypisz() => Console.WriteLine(ToString());
    }
}