using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracte
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public void PrintArea()
        {
           Console.WriteLine("Area: " + GetArea()); 
        }

        public void PrintPerimeter()
        {
            Console.WriteLine("Perimeter: " + GetPerimeter());
        }
    }

    
}
