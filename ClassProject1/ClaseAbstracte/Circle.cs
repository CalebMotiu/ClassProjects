using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracte
{
    internal class Circle : Shape
    {
        public Circle(int radius) 
        {
            this.Radius = radius;
            this.Diameter = radius * 2;
        }

        public const double pi = 3.14;

        public int Diameter { get; }

        public int Radius { get; }
        public override double GetArea()
        {
            return this.Radius * this.Radius * pi;
        }

        public override double GetPerimeter()
        {
            return 2 * this.Radius * pi;
        }

        public void PrintDiameter()
        {
            Console.WriteLine("Diameter: " + this.Diameter);
        }

    }
}
