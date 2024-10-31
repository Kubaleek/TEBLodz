using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_31._10._2024
{
    internal class Kot : Zwierze
    {
        protected string _kolor;

        public Kot() : base()
        {
            // _imie
            // _wiek
            _kolor = string.Empty;
        }

        public Kot(string imie, int wiek, string kolor) : base(imie, wiek)
        {
            _kolor = kolor;
        }

        public string Kolor
        {
            get { return _kolor; }
            set { _kolor = value; }
        }

        public override string ToString() {
            return "";
        }

        public override string DajGlos() {
            return "";
        }

        public override string PrzedstawSie()
        {
            return $"Jestem kotem o imieniu {Imie}, mam lat {Wiek} oraz posiadam kolor {Kolor}";
        }
    }
}
