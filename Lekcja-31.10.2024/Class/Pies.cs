using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_31._10._2024
{
    internal class Pies : Zwierze
    {
        protected string _rasa;

        public Pies() : base()
        {
            _rasa = string.Empty;
        }

        public Pies(string imie, int wiek, string rasa) : base(imie, wiek)
        {
            _rasa = rasa;
        }

        public string Rasa
        {
            get { return _rasa; }
            set { _rasa = value; }
        }

        public override string ToString() {
            return "";
        }

        public override string DajGlos() {
            return "";
        }
        public override string PrzedstawSie()
        {
            return $"Jestem kotem o imieniu {Imie}, mam lat {Wiek} i moja rasa {Rasa}";
        }
    }
}
