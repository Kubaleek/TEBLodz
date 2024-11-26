using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_25._11._2024.Class
{
    public class Garaż
    {
        private List<Auto> _auta;
        private int _maksymalnaLiczbaAut;

        public List<Auto> Auta { get => _auta; set => _auta = value; }
        public int MaksymalnaLiczbaAut { get => _maksymalnaLiczbaAut; set => _maksymalnaLiczbaAut = value; }

        public Garaż() => (_auta, _maksymalnaLiczbaAut) = (new List<Auto>(), 0);

        public Garaż(List<Auto> auta, int maksymalnaLiczbaAut) => (_auta, _maksymalnaLiczbaAut) = (auta, maksymalnaLiczbaAut);

        public void DodajAuto(Auto auto)
        {
            if (Auta.Count < MaksymalnaLiczbaAut)
            {
                Auta.Add(auto);
                Console.WriteLine($"Dodano Auto {auto}");
            }
            else
            {
                Console.WriteLine("Brak miejsca w garażu!");
            }
        }

        public void UsunAuto(Auto auto)
        {
            if (Auta.Remove(auto))
            {
                Console.WriteLine("Usunięto auto z garażu.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono auta w garażu.");
            }
        }

        public void ileAut() => Console.WriteLine($"Ilość auto w garazu: {Auta.Count}");

        public void usunAuta()
        {
            Auta.Clear();
            Console.WriteLine("Wszystkie auta zostały usunięte z garażu.");
        }


        public override string ToString()
        {
            return $"Garaż (maks: {MaksymalnaLiczbaAut}, obecnie: {Auta.Count}):\n" + string.Join("\n", Auta);
        }

        public void Wypisz() => Console.WriteLine(ToString());

    }
}
