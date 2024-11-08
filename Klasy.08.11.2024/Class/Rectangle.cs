using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy._08._11._2024.Class
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;


        public int Width
        {
            get => _width; 
            set => _width = value;
        }

        public int Height
        {
            get => _height;
            set => _height = value;
        }

        // Konstruktory
        public Rectangle() => (_width, _height) = (0, 0);
        public Rectangle(int width, int height) => (_width, _height) = (width, height);

        // Metody
        public override double GetArea() => Width * Height;
        public override double GetPerymetr() => (2 * Width) + (2 * Height);
        public override string Draw() => $"Rysuję Prostokąt";
        public override string ToString() => $"Prostokąt:\nSzerokość: {Width}, Wysokość:{Height}";
        public override void Write() => Console.WriteLine($"{Draw()}\n{ToString()}");


    }
}
