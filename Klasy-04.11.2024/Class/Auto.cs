using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_04._11._2024.Class
{
 //  Utwórz klasę Auto z następującymi właściwościami:
 //  marka– (private), typ string, reprezentuje markę samochodu(np.
 //  "Toyota").
 //  model– (private), typ string, reprezentuje model samochodu(np.
 //  "Corolla").
 //  rokProdukcji– (private), typ int, reprezentuje rok produkcji
 //  samochodu.
 //  przebieg– (private), typ int, reprezentuje przebieg samochodu w
 //  kilometrach.
 //  Dodaj konstruktor domyślny.
 //  Dodaj konstruktor do klasy Auto, który przyjmuje Marka, Model,
 //  RokProdukcji i Przebieg jako argumenty i przypisuje je do
 //  odpowiednich właściwości.
 //  Dodaj Gettery i Settery
 //  Dodaj metodę Jazda, która przyjmuje parametr kilometry typu int i
 //  zwiększa Przebieg o podaną wartość.Wyświetl komunikat
 //  "Samochód przejechał X kilometrów".
 //  Dodaj metodę toString() oraz metodę Wypisz()

    public class Auto
    {
        private string _marka;
        private string _model;
        private int _rokProdukcji;
        private int _przebieg;

        public Auto()
        {
            _marka = string.Empty;
            _model = string.Empty;
            _rokProdukcji = 0;
            _przebieg = 0;
        }

        public Auto(string marka, string model, int rokProdukcji, int przebieg)
        {
            _marka = marka;
            _model = model;
            _rokProdukcji = rokProdukcji;
            _przebieg = przebieg;
        }

        public string Marka
        {
            get => _marka;
            set => _marka = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int RokProdukcji
        {
            get => _rokProdukcji;
            set => _rokProdukcji = value;
        }

        public int Przebieg
        {
            get => _przebieg;
            set => _przebieg = value;
        }


        public void Jazda(int kilometry)
        {
            Przebieg += kilometry;
            Console.WriteLine($"\nSamochód przejechał {kilometry} kilometrów.\n");
        }

        public override string ToString()
        {
            return $"\nMarka: {Marka}, Model: {Model}, Rok Produkcji: {RokProdukcji}, Przebieg: {Przebieg} \n";
        }

        public void Wypisz() => Console.WriteLine(ToString());
    }
}
