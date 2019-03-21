using Caffetteria.Beverages;
using Caffetteria.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage c = new Espresso();
            c = new Milk(c);
            c = new Moka(c);            
            Console.WriteLine(c.Description);
            Console.WriteLine(c.Cost);

            Beverage cc = new Espresso();
            cc = new Grappa(cc);
            Console.WriteLine(cc.Description);
            Console.WriteLine(cc.Cost);

            Console.ReadKey(true);
        }
    }
}
