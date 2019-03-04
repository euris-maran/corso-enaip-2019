using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class DataStructures
    {
        string[] stringhe = new string[4];
        int[] interi = new int[10];
        double[] numeri;

        public void Array()
        {
            stringhe[0] = "uno";
            string primaStringa = stringhe[0];
            primaStringa = "due";

            int dim = 5;
            numeri = new double[dim];
        }
    }
}
