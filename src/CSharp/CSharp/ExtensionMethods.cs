using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class ExtensionMethods
    {
        internal void Run()
        {
            DateTime birth = new DateTime(1986, 5, 2);
            Console.WriteLine(birth.ToString());
            Console.WriteLine(birth.ToShortDateString());

            DateTime nextFirst
                //= NextFirstOfMonth(DateTime.Today);
                //= DateExtensions.NextFirstOfMonth(DateTime.Today, 2);
                = DateTime.Today.NextFirstOfMonth(2);
            
            Console.WriteLine(nextFirst.ToShortDateString());
        }

        string FormatAsMyDate(DateTime dateTime)
        {
            return $"Anno: { dateTime.Year }, Mese: { dateTime.Month }, Giorno: { dateTime.Day }";
        }

        DateTime NextFirstOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1);
        }
    }

}

namespace Extensions
{
    static class DateExtensions
    {
        public static DateTime NextFirstOfMonth(this DateTime dateTime, int months)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(months);
        }
    }
}
