using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class.Garage.Types
{
    internal class DużyGaraz : Garaz
    {
        private string _typ;

        public string Typ => _typ;

        public DużyGaraz(List<Auto> auta) : base(auta, 8) =>
            (_typ) = ("Duży Garaż");

        public override string ToString()
        {
            return $"{Typ}: {base.ToString()}";
        }

        public override void Wypisz() => Console.WriteLine(ToString());
    }
}
