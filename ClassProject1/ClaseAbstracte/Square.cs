using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracte
{
    internal class Square : Shape
    {
        public Square(int side) 
        {
            Side = side;
        }

        public int Side { get; }
        public override double GetArea()
        {
            return  Side * Side; 
        }

        public override double GetPerimeter()
        {
            return Side * 4;
        }
    }
}
