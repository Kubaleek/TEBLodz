using Klasy._08._11._2024.Class;

namespace Klasy._08._11._2024
{
    internal class Program
    {

        static void CircleClass()
        {
            Circle circle = new Circle(5);

            Console.WriteLine(new string('-', 18));
            circle.Write();
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(new string('-', 18));
        }

        static void RectangleClass()
        {
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine(new string('-', 18));
            rectangle.Write();
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(new string('-', 18));
        }

        static void TriangleClass()
        {
            Triangle triangle = new Triangle(5,7);
            Console.WriteLine(new string('-', 18));
            triangle.Write();
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(new string('-', 18));
        }

        static void Shows()
        {
            CircleClass();

            Console.ReadKey();

            RectangleClass();

            Console.ReadKey();

            TriangleClass();

        }
        static void Main(string[] args)
        {
            Shows();
        }
    }
}
