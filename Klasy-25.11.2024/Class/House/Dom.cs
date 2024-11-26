using Klasy_25._11._2024.Class.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class.House
{
    public class Dom
    {
        private string _adres;
        private int _liczbaPokoi;
        private double _powierzchnia;
        private bool _czyKupiony;
        private Garaz _garaz;

        public string Adres { get => _adres; set => _adres = value; }
        public int LiczbaPokoi { get => _liczbaPokoi; set => _liczbaPokoi = value; }
        public double Powierzchnia { get => _powierzchnia; set => _powierzchnia = value; }
        public bool CzyKupiony { get => _czyKupiony; set => _czyKupiony = value; }

        public Garaz Garaz { get => _garaz; set => _garaz = value; }


        public Dom() 
            => (_adres, _liczbaPokoi, _powierzchnia, _czyKupiony, _garaz) = (string.Empty, 0, 0.0, false, null);

        public Dom(string adres, int liczbaPokoi, double powierzchnia, bool czyKupiony, Garaz garaz)
            => (_adres, _liczbaPokoi, _powierzchnia, _czyKupiony, _garaz) = (adres, liczbaPokoi, powierzchnia, czyKupiony, garaz);

        public override string ToString() =>
            $"Adres\n   * {Adres}\n" +
            $"Liczba pokoi\n   * {LiczbaPokoi}\n" +
            $"Powierzchnia\n   * {Powierzchnia} m²\n" +
            $"CzyJestKupiony\n   * {(CzyKupiony ? "Tak" : "Nie")}\n" +
            $"Garaż\n   * {(Garaz != null ? Garaz.ToString() : "Brak garażu")}\n";

        public void Wypisz() => Console.WriteLine(ToString());




    }
}
