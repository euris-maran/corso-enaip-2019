using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MockShape : IShape
    {
        public double CalculateArea()
        {
            return 1;
        }

        public double CalculatePerimeter()
        {
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Triangle(5, 6, 3));
            shapes.Add(new Square(4));
            shapes.Add(new Rectangle(6, 8));
            shapes.Add(new Circle(4));

            //shapes.Add(new MockShape());

            foreach (IShape shape in shapes)
            {
                WriteShape(shape);
            }

            Console.ReadKey(true);
        }

        private static void WriteShape(IShape shape)
        {
            if (shape is IDescriptable)
            {
                Console.WriteLine($"La forma è un { (shape as IDescriptable)?.Description }");
            }
            Console.WriteLine(string.Format("La sua area è {0:n}", shape.CalculateArea()));
            string perimeterDesc = shape is Circle ? "La sua circonferenza" : "Il suo perimetro";
            Console.WriteLine(string.Format("{0} è {1:n}", perimeterDesc, shape.CalculatePerimeter()));
            Console.WriteLine();
        }
    }
}
