using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class Calculator
    {
        public static float OperationsWithNumbers(float a, float b, string oper)
        {
            float result;
            switch (oper)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
