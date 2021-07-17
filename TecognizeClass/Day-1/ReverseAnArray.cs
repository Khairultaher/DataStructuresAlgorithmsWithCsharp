using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecognizeClass.Day_1
{
    public static class ReverseAnArray
    {
        static int[] array = new int[] { 8, 7, 2, 5, 3, 1 };

        // O(n) time | O(n^2) space
        public static int[] BruteForce()
        {
            int[] newarray = new int[array.Length];
            for (int i = newarray.Length - 1; i >= 0; i--)
            {
                newarray.Append(array[i]);
                Console.WriteLine(array[i]);
            }

            return newarray;
        }

        // O(n) time | O(n) space
        public static int[] UsingSwap()
        {
            int len = array.Length;
            int start = 0;  int end = len - 1;

            while (start < len / 2)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++; end--;
            }

            //for (int i = start; i < len / 2; i++)
            //{
            //    int temp = array[i];
            //    array[i] = array[end];
            //    array[end] = temp;

            //    start++; end--;
            //}

            return array;
        }
    }
}
