using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public static class Searching
    {
        // O(n) time | O(1)
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) 
                {
                    return i;
                }
            }
            return -1;
        }

        // O(log(n)) time | O(1) space
        public static int BynarySearchIteration(int[] arr, int target)
        {
            //Array.Sort(arr);
            int min = 0; int max = arr.Length - 1;
            while (min <= max)
            {
                int middle = (min + max) / 2;
                if (target == arr[middle])
                {
                    return middle;
                }
                else if (target > arr[middle])
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


        // O(log(n)) time | O(log(n)) space
        public static int BynarySearchRecursive(int[] arr, int target)
        {
            //Array.Sort(arr);
            int min = 0; int max = arr.Length - 1;
            if (min > max)
            {
                return -1;
            }
            else 
            {
                int middle = (min + max) / 2;
                if (target == arr[middle])
                {
                    return middle;
                }
                else if (target > arr[middle])
                {
                    var right = arr.Skip(middle).ToArray();
                    return BynarySearchRecursive(right, target);
                }
                else
                {
                    var left = arr.Skip(0).Take(middle).ToArray();
                    return BynarySearchRecursive(left, target);
                }
            }
        }
    }
}
