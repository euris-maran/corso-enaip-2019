using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class ValueAndReference
    {
        public void Test()
        {
            int i = 1;
            System.Diagnostics.Debug.WriteLine(i);
            ChangeValueType(i);
            System.Diagnostics.Debug.WriteLine(i);
            ChangeValueTypeByRef(ref i);
            System.Diagnostics.Debug.WriteLine(i);
        }

        void ChangeValueTypeByRef(ref int intero)
        {
            System.Diagnostics.Debug.WriteLine(intero);
            intero = 10;
            System.Diagnostics.Debug.WriteLine(intero);
        }

        void ChangeValueType(int intero)
        {
            System.Diagnostics.Debug.WriteLine(intero);
            intero = 10;
            System.Diagnostics.Debug.WriteLine(intero);
        }
    }
}
