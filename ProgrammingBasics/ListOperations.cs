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

        public static void LettersRepetition(string word)
        {
            // -- koristeci Dictionary --

            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (var i = 0; i <= word.Length - 1; i++)
            {
                if (!letters.ContainsKey(word[i]))
                    letters.Add(word[i], 1);
                else
                    letters[word[i]]++;
            }

            foreach (KeyValuePair<char, int> kvp in letters)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }

            /* -- koristeci List --

            var letters = new List<char>();
            var numRep = new List<int>();
                
            for (var i = 0; i <= word.Length - 1; i++)
            {
                if (!letters.Contains(word[i]))
                {
                    letters.Add(word[i]);
                    numRep.Add(1);
                }
                else
                    numRep[letters.IndexOf(word[i])]++;
            }
            for (var i = 0; i <= letters.Count - 1; i++)
            {
                Console.WriteLine("{0} - {1}", letters[i], numRep[i]);
            }
            */
        }

        public static string ExludeDuplicatedLetters(string word)
        {
            // -- koristeci HashSet --

            HashSet<char> letters = new HashSet<char>(word);
            string newWord = String.Empty;

            foreach (char c in letters)
            {
                newWord += c;
            }

            return newWord;
            
            /* -- koristeci List --
            
            var letters = new List<char>() { };
            var newWord = String.Empty;
            for (var i = 0; i <= word.Length - 1; i++)
            {
                if (!letters.Contains(word[i]))
                {
                    letters.Add(word[i]);
                    newWord += word[i];
                }
            }
            return newWord;
            */
        }

    }
}
