using static Figure.Rectangle;
using static Figure.Rectangle.Circle;

namespace Figure
{

    public class Figure
    {
        public virtual double GetSquare()
        {
            return 0;
        }
    }
    public class Rectangle : Figure

    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetSquare()
        {
            return Width * Height;
        }
        public class Circle : Figure
        {
            public double Radius { get; set; }
            public override double GetSquare()
            {
                return Math.PI * Radius * Radius;
            }
        }
        public class Triangle : Figure
        {
            private double side1;
            private double side2;
            private double side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public override double GetSquare()
            {
                // Используем формулу Герона для вычисления площади треугольника
                double p = (side1 + side2 + side3) / 2;
                double square = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                return square;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine("Площадь прямоугольника:" + rectangle.GetSquare());

            Circle circle = new Circle();
            circle.Radius = 3;
            Console.WriteLine("Площадь круга:" + circle.GetSquare());


            Triangle triangle = new Triangle(3, 4, 5);
            double square = triangle.GetSquare();
            Console.WriteLine("Площадь треугольника: " + square);

        }
    }
}
