using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms
{
    public static class TwoNumberSum
    {
        static int[]  array = new int[] { 8, 7, 2, 5, 3, 1 }; 
        static int target = 10;

        // O(n^2) time | O(n) space
        public static void BruteForce()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.WriteLine($"{array[i]}, {array[j]}");
                        return;
                    }
                }
            }
        }

        // O(n) time | O(n) space
        public static int[] UsingHashing() 
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (var num in array)
            {
                var potentialMatch = target - num;
                if (nums.Contains(potentialMatch)){
                    return new int[] { potentialMatch, num };
                }
                else {
                    nums.Add(num);
                }
            }
            return new int[0];
        }
       
        // O(nlog(n)) time | O(1) space
        public static int[] UsingSorting() {
            Array.Sort(array);
            int left = 0, right = array.Length - 1;
            while (left < right) {
                int sum = array[left] + array[right];
                if (sum == target){
                    return new int[] { array[left], array[right] };
                }
                else if (sum < target){
                    left += 1;
                }
                else if (sum > target) {
                    right -= 1;
                }
            }
            return new int[0];
        }
    }
}
