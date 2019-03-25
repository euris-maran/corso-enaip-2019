using Caffetteria.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Condiments
{
    public class Grappa : Condiment
    {
        public Grappa(Beverage beverage) : base(beverage)
        {

        }

        public override string Description => _beverage.Description + ", Grappa";

        public override double Cost => _beverage.Cost + 0.30;
    }
}
