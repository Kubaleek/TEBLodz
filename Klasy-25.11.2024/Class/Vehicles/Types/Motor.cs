using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class
{
    public class Motor : Pojazd
    {
        private string _typ;
        private bool _czyMaKufry;

        public string Typ { get => _typ; set => _typ = value; }
        public bool CzyMaKufry { get => _czyMaKufry; set => _czyMaKufry = value; }


        public Motor() : base() => 
            (_typ, _czyMaKufry) = (string.Empty, false);

        public Motor(string typ, bool czyMaKufry, string nazwa, int iloscKol, int rejestracja) : base(nazwa, iloscKol, rejestracja) => 
            (_typ, _czyMaKufry) = (typ, czyMaKufry);

        public override string ToString() =>
            $"{base.ToString()}\n" +
            $" Typ         : {Typ}\n" +
            $" CzyMaKufry  : {(CzyMaKufry ? "Tak" : "Nie")}\n" +
            $"----------------------";
        public override void Wypisz() => Console.WriteLine(ToString());


    }
}
