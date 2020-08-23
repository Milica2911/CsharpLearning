using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class NumberOperations
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static bool PositiveOrNegative(int c)
        {
            return c >= 0;
        }

        public static bool DivisionWithFive(int d)
        {
            return d % 5 == 0;
        }

        public static string EvenOrOdd(int e)
        {
            if (e % 2 == 0)
                return "even";
            else
                return "odd";
        }

        public static int DivisionWithRemainder(int a, int b)
        {
            return a % b;
        }

        public class Paper
        {
            public float width, length;
            public Paper(float width, float length)
            {
                this.width = width;
                this.length = length;
            }

            public void PrintDimensions()
            {
                Console.WriteLine("Dimensions of one sheet of A4 (210×297 mm) paper expressed in inches are {0} x {1}", width, length);
            }
        }

        public static Paper A4PaperToInches()
        {
            float a = 210 / 25.4f;
            float b = 297 / 25.4f;

            return new Paper(a, b);
        }

        public static float CelsiusToFahrenheit(float c)
        {
            float f = 9 * c / 5 + 32;
            return f;
        }

        public static void StarTriangle(int starNumber)
        {
            for (int i = 1; i <= starNumber; i++)
            {
                string stars = new String('*', i);
                Console.WriteLine(stars);
            }
        }

        public static void AllLessThen(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0} ", i);
                sum += i;
            }
            Console.WriteLine("Their sum is {0}", sum);
        }

        public static void EnteredNumber(int num)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("User entered number 0");
                    break;
                case 1:
                    Console.WriteLine("User entered number 1");
                    break;
                case 2:
                    Console.WriteLine("User entered number 2");
                    break;
                case 3:
                    Console.WriteLine("User entered number 3");
                    break;
                case 4:
                    Console.WriteLine("User entered number 4");
                    break;
                case 5:
                    Console.WriteLine("User entered number 5");
                    break;
                case 6:
                    Console.WriteLine("User entered number 6");
                    break;
                case 7:
                    Console.WriteLine("User entered number 7");
                    break;
                case 8:
                    Console.WriteLine("User entered number 8");
                    break;
                case 9:
                    Console.WriteLine("User entered number 9");
                    break;
            }
        }

        public static int NumbersComparison(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }

        public static void ValuesSwapping(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void PyramideOfNumbers(int numRows)
        {
            var numSpaces = numRows;
            // petlja za broj razmaka
            for (int i = 1; i <= numRows; i++)
            {
                numSpaces--;
                string pyramide = new string(' ', 2 * numSpaces);
           
                // petlja za ispis brojeva unutar svakog reda
                for (var j = 1; j <= 2 * i - 1; j++)
                {
                    pyramide += j + " ";
                }
                Console.WriteLine(pyramide);
            }
        }

    }
}
