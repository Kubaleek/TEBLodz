using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_31._10._2024
{
    internal class Krowa : Zwierze
    {
        public Krowa() : base()
        {

        }

        public Krowa(string imie, int wiek) : base(imie, wiek)
        {
        }
        public override string ToString()
        {
            return "";
        }

        public override string DajGlos()
        {
            return "";
        }
        public override string PrzedstawSie()
        {
            return $"Jestem krową o imieniu {Imie}, mam lat {Wiek}";
        }
    }
}
