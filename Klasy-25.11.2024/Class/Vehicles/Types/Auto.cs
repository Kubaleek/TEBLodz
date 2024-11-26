using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class
{
    public class Auto : Pojazd
    {
        private string _model;
        private string _marka;
        private string _kolor;
        private bool _przeglad;

        public string Model { get => _model; set => _model = value; }
        public string Marka { get => _marka; set => _marka = value; }
        public string Kolor { get => _kolor; set => _kolor = value; }
        public bool Przeglad { get => _przeglad; set => _przeglad = value; }

        public Auto() : base() => 
            (_model, _marka, _kolor, _przeglad) = (string.Empty, string.Empty, string.Empty, false);

        public Auto(string model, string marka, string kolor, bool przeglad, string nazwa, int iloscKol, int rejestracja) : base(nazwa, iloscKol, rejestracja) => 
            (_model, _marka, _kolor, _przeglad) = (model, marka, kolor, przeglad);


        public override string ToString() =>
            $"\n{base.ToString()}\n" +
            $" Model       : {Model}\n" +
            $" Marka       : {Marka}\n" +
            $" Kolor       : {Kolor}\n" +
            $" Przegląd    : {(Przeglad ? "Tak" : "Nie")}\n" +
            $"----------------------\n";
        public override void Wypisz() => Console.WriteLine(ToString());

    }
}
