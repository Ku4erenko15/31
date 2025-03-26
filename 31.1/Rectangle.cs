using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    class Rectangle : Figure
    {
        private double side1, side2;

        public Rectangle(double side1, double side2) : base("Прямоугольник")
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public override double Area() => side1 * side2;
        public override double Perimeter() => 2 * (side1 + side2);

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: {side1}, {side2}, Площадь: {Area()}, Периметр: {Perimeter()}");
        }
    }
}
