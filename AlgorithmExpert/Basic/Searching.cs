using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Basic
{
    public static class Searching
    {
        // O(log(n)) time | O(n)
        public static int BynarySearch(int[] arr, int target)
        {
            Array.Sort(arr);
            int min = 0; int max = arr.Length - 1;
            while (min <= max)
            {
                int middle = (min + max) / 2;
                int match = arr[middle];
                if (target == match)
                {
                    return arr[middle];
                }

                if (target > arr[middle])
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }

            return -1;
        }

    }
}
