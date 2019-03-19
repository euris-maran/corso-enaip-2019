using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : IShape, IDescriptable
    {
        readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public string Description { get { return $"Quadrato di lato { _side }"; } }

        public double CalculateArea()
        {
            return Math.Pow(_side, 2);
        }

        public double CalculatePerimeter()
        {
            return _side * 4;
        }
    }
}
