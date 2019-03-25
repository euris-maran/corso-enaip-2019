using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Beverages
{
    public class Espresso : Beverage
    {
        public override string Description => "Espresso";

        public override double Cost => 1.00;
    }
}
