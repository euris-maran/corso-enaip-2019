using Caffetteria.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Condiments
{
    public abstract class Condiment : Beverage
    {
        protected readonly Beverage _beverage;

        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }        
    }
}
