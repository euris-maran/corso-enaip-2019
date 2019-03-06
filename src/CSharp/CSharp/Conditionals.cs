using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Conditionals
    {
        void If()
        {
            int i = 0;
            if (i > 1 && i < 10 && i != 7)
            {

            }
            else if (i >= 2 || i == 5)
            {

            }
            else
            {

            }
        }

        void Switch()
        {
            string test = "A";

            switch (test)
            {
                case "A":
                    break;
                case "B":
                    break;
                case "ESC":
                default:
                    break;
            }
        }
    }
}
