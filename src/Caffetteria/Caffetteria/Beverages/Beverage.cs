using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Beverages
{
    public abstract class Beverage
    {
        public abstract string Description { get; }

        public abstract double Cost { get; }
    }
}
