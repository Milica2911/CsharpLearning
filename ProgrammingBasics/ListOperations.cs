using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class ListOperations
    {
        public static int LastElement(List<int> list)
        {
            var n = list.Count;
            return list[n - 1];
        }

        public static string ListToString(List<int> list)
        {
            string ListString = list[0].ToString();
            for (int i = 1; i <= list.Count - 1; i++)
            {
                ListString += ", " + list[i];
            }
            return ListString;
        }
    }
    
}
