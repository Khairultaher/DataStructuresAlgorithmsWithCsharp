using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert
{
    public static class TwoNumberSum
    {
        // O(n) time | O(n) space
        public static int[] TwoNumberSum1(int[] array, int target) 
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
        // int[] array = new int[] {3,5,-4,8,11,1,-1,6}; var target = 10;
        // O(nlog(n)) time | O(1) space
        public static int[] TwoNumberSum2(int[] array, int target) {
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
