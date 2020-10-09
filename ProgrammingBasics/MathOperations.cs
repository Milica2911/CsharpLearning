using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProgrammingBasics
{
    class MathOperations
    {
        public int Square(int a)
        {
            return a * a;
        }
    }

    class DataProcessing : MathOperations
    {
        public void Processing()
        {
            // 1) ovaj metod iscitava podatke iz Excel fajla "DataInput" (brojevi iz prve kolone)
            // 2) poziva metod Square() za svaki od ucitanih brojeva
            // 3) ispisuje rezultat u novi Excel fajl "DataResult"

            // nezavrseno! 
        }
    }


}
