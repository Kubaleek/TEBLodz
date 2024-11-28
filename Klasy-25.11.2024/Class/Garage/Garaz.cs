using System;
using System.Collections.Generic;

namespace Klasy_25._11._2024.Class.Garage
{
    public class Garaz
    {
        private List<Auto> _auta;
        private int _maksymalnaLiczbaAut;

        public List<Auto> Auta { get => _auta; set => _auta = value; }
        
        public int MaksymalnaLiczbaAut { get => _maksymalnaLiczbaAut; set => _maksymalnaLiczbaAut = value; }

        public Garaz(List<Auto> auta, int maksymalnaLiczbaAut)
        {
            _auta = auta ?? new List<Auto>();  // Zapewnia inicjalizację listy, jeżeli jest null
            _maksymalnaLiczbaAut = maksymalnaLiczbaAut;
        }


        public void DodajAuto(Auto auto)

        {
            if (Auta.Count < MaksymalnaLiczbaAut)
            {
                Auta.Add(auto);
            }
            else
            {
                Console.WriteLine("Brak miejsca w garażu!");
            }
        }
        public bool UsunAuto(Auto auto)
        {
            if (Auta.Remove(auto))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }


        public void IleAut() => Console.WriteLine($"Ilość aut w garażu: {Auta.Count}");

        public void UsunWszystkieAuta()
        {
            Auta.Clear();
            Console.WriteLine("Wszystkie auta zostały usunięte z garażu.");
        }


        public override string ToString()

        {
            if (Auta == null)
            {
                return $"(maks: {MaksymalnaLiczbaAut}, obecnie: 0, brak aut)";
            }
            return $"(maks: {MaksymalnaLiczbaAut}, obecnie: {Auta.Count})";
        }

        public virtual void Wypisz() => Console.WriteLine(ToString());
    }
}
