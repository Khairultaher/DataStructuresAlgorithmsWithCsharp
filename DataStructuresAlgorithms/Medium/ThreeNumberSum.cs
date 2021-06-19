using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Medium
{
    public static class ThreeNumberSum
    {
        // O(n^2) time | O(n) space
        public static List<int[]> Sum(int[] array, int targetSum)
        {
            Array.Sort(array);
            List<int[]> triplets = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int currentSum = array[i] + array[left] + array[right];
                    if (currentSum == targetSum)
                    {
                        int[] newTriplet = { array[i], array[left], array[right] };
                        triplets.Add(newTriplet);
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum)
                    {
                        left++;
                    }
                    else if (currentSum > targetSum)
                    {
                        right--;
                    }
                }
            }
            return triplets;
        }

    }
}