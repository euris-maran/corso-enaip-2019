using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public string Description { get { return $"Circonferenza di raggio { _radius }"; } }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public double CalculateCircumference()
        {
            return CalculatePerimeter();
        }
    }
}
