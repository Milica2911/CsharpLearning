using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class GradeScale
    {
        public static int AverageGrade(int gr1, int gr2, int gr3)
        {
            float finalPoints = (gr1 + gr2 + gr3) / 3;

            int finalGrade;
            if (finalPoints > 90)
                finalGrade = 10;
            else if (finalPoints > 80)
                finalGrade = 9;
            else if (finalPoints > 70)
                finalGrade = 8;
            else if (finalPoints > 60)
                finalGrade = 7;
            else if (finalPoints > 50)
                finalGrade = 6;
            else
                finalGrade = 5;

            return finalGrade;
        }
    }
}
