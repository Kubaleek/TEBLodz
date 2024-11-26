using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class.Garage.Types
{
    public class MałyGaraz : Garaz
    {
        private string _typ;

        public string Typ => _typ;

        public MałyGaraz(List<Auto> auta) : base(auta, 2) =>
            (_typ) = ("Maly Garaż");

        public override string ToString()
        {
            return $"{Typ}: {base.ToString()}";
        }

        public override void Wypisz() => Console.WriteLine(ToString());
    }
}
