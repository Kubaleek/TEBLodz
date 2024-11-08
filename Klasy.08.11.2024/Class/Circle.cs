using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy._08._11._2024.Class
{
    public class Circle : Shape
    {
        private int _radius;

        public int Radius
        {
            get => _radius; set => _radius = value;
        }

        // Konstruktory
        public Circle() => (_radius) = (0);
        public Circle(int radius) => (_radius) = (radius);

        // Metody
        public override double GetArea() => Math.PI * (Radius * Radius);
        public override double GetPerymetr() => 2 * Math.PI * Radius;
        public override string Draw() => $"Rysuję Koło";
        public override string ToString() => $"Promień Koła: {Radius}";
        public override void Write() => Console.WriteLine($"{Draw()}\n{ToString()}");

    }
}
