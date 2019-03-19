using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShape
    {
        readonly double _aSide;
        readonly double _bSide;
        readonly double _cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }

        public string Description { get { return $"Triangolo di lati { _aSide }, { _bSide }, { _cSide }"; } }

        public double CalculateArea()
        {
            double semiperimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _aSide) * (semiperimeter - _bSide) * (semiperimeter - _cSide));
        }

        public double CalculatePerimeter()
        {
            return _aSide + _bSide + _cSide;
        }
    }
}
