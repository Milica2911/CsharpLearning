using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class ArrayOperations
    {
        public static int[] SortingFromSmallestToLargest(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            }
            return arr;
        }

        public static int SecondBiggestArrayNumber(int[] arr)
        {
            ArrayOperations.SortingFromSmallestToLargest(arr);
            return arr[arr.Length - 2];
        }

        public static string ArrayToString(int[] arr)
        {
            string ArrString = arr[0].ToString();
            for (int i = 1; i <= arr.Length-1; i++)
            {
                ArrString += ", " + arr[i];
            }
            return ArrString;
        }

        public static string ArrayToString(float[] arr)
        {
            string ArrString = arr[0].ToString();
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                ArrString += ", " + arr[i];
            }
            return ArrString;
        }

        public static int AppearanceOfElement(float[] arr)
        {
            int x = 0;
            for (int i = 0; i <= arr.Length -1; i++)
            {
                if (arr[i] == 5)
                x += 1;
            }
            return x;
        }

    }
}
