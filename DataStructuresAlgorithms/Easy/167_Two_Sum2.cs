using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class Two_Sum2
    {
        static int[] numbers = new int[] { 2, 7, 11, 15 };
        static int target = 9;
        //Explanation: The sum of 2 and 7 is 9.
        //Therefore index1 = 1, index2 = 2.
        // O(nlog(n)) time | O(1) space
        public static int[] UsingSorting()
        {
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return new int[] {left+1, right+1 };
                }
                else if (sum < target)
                {
                    left += 1;
                }
                else if (sum > target)
                {
                    right -= 1;
                }
            }
            return new int[0];
        }
    }
}
