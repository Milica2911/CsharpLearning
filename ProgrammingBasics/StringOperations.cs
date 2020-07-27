using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class StringOperations
    {
        public static string NameConcat(string name, string surname)
        {
            string fullName = string.Concat(surname, ", ", name);
            return fullName;
        }

        public static void StringComparison(string a, string b)
        {
            if (String.Equals(a, b))
                Console.WriteLine("{0} and {1} are equal strings.", a, b);
            else
                Console.WriteLine("{0} and {1} are not equal strings.", a, b);
        }

        public static string ReverseLetterOrder(string word)
        {
            string reversed = String.Empty;
            for (var i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            return reversed;

        }

        public static string ReplacingChar(string sentence)
        {
            string resString = "";
            for (int i = 0; i <= sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ')
                    resString += '_';
                else
                    resString += sentence[i];
            }
            return resString;
        }

        public static string SwappingFirstAndLastChar(string randomString)
        {
            string resString = randomString[randomString.Length-1].ToString();
            for (int i = 1; i < randomString.Length - 1; i++)
            {
                resString += randomString[i];
            }
            resString += randomString[0];
            return resString;
        }



    }
}
