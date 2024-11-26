using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class.Garage.Types
{
    public class ŚredniGaraz : Garaz
    {
        private string _typ;

        public string Typ => _typ;

        public ŚredniGaraz(List<Auto> auta) : base(auta, 4) =>
            (_typ) = ("Średni Garaż");

        public override string ToString()
        {
            return $"{Typ}: {base.ToString()}";
        }

        public override void Wypisz() => Console.WriteLine(ToString());
    }
}
