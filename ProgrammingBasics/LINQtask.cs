using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    class LINQtask
    {
        public static void SortCapitals(string[] capitals)
        {
            var sorted = from city in capitals
                         orderby city.Length ascending, city ascending
                         select city;

            foreach (string capital in sorted)
            {
                Console.WriteLine(capital);
            }
        }
    
    }
}
