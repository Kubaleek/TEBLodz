using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy._08._11._2024.Class
{
    internal class Triangle : Shape
    {
        private int _tbase;
        private int _height;

        public int TBase
        {
            get => _tbase; 
            set => _tbase = value;
        }

        public int Height
        {
            get => _height; 
            set => _height = value;
        }

        // Konstruktory

        public Triangle() => (_tbase, _height) = (0,0);
        public Triangle(int tbase, int height) => (_tbase, _height) = (tbase,height);

        // Metody
        public override double GetArea() => (TBase * Height) / 2;
        public override double GetPerymetr() => (3 * TBase);
        public override string Draw() => $"Rysuję Trójkat";
        public override string ToString() => $"Trójkat:\nPodstawa: {TBase}, Wysokość:{Height}";
        public override void Write() => Console.WriteLine($"{Draw()}\n{ToString()}");
    }
}
