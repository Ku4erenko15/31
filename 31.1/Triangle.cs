using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c) : base("Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double Perimeter() => a + b + c;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: {a}, {b}, {c}, Площадь: {Area()}, Периметр: {Perimeter()}");
        }
    }

}
