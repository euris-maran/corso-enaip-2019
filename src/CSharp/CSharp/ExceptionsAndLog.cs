using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class ExceptionsAndLog
    {
        public void Run()
        {
            try
            {
                FailureMethod();
            }
            catch (Exception e)
            {
            }
        }

        public void FailureMethod()
        {
            string a = null;

            try
            {
                int l = a.Length;
                int[] arr = new int[3];
                int n = arr[5];
            }
            catch (IndexOutOfRangeException)
            {
            }
            catch (NullReferenceException nre)
            {
                throw new Exception("asdasdasd", nre);
            }
            finally
            {

            }
        }
    }
}
