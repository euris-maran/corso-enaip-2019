using Caffetteria.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Condiments
{
    public class Moka : Condiment
    {
        public Moka(Beverage beverage) : base(beverage)
        {

        }

        public override string Description => _beverage.Description + ", Moka";

        public override double Cost => _beverage.Cost + 0.20;
    }
}
