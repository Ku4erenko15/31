using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            name = "Квадрат";
        }
    }

    class Circle : Figure
    {
        private double radius;

        public Circle(double radius) : base("Круг")
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double Area() => Math.PI * radius * radius;
        public override double Perimeter() => 2 * Math.PI * radius;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}, Площадь: {Area()}, Периметр: {Perimeter()}");
        }
    }
}
