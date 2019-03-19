using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //public abstract class Shape
    //{
    //    public abstract string Description { get; }

    //    public abstract double CalculateArea();

    //    public abstract double CalculatePerimeter();
    //}

    public interface IDescriptable
    {
        string Description { get; }
    }

    public interface IShape
    {

        double CalculateArea();

        double CalculatePerimeter();
    }
}
