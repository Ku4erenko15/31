using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    abstract class Figure
    {
        protected string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {name}");
        }
    }
}
