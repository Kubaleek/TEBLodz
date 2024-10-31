using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_31._10._2024
{
    internal abstract class Zwierze
    {
        protected string _imie;
        protected int _wiek;

        public Zwierze()
        {
            _imie = string.Empty;
            _wiek = 0;
        }

        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        public int Wiek
        {
            get { return _wiek; }
            set { _wiek = value; }
        }

        public Zwierze(string imie, int wiek)
        {
            _imie = imie;
            _wiek = wiek;
        }

        public string Imie2() {
            return "";
        }
        public int Wiek2() {
            return 0;
        }
        public abstract string DajGlos();
        public virtual string PrzedstawSie() {
            return "";
        }
    }
}
