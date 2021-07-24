using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Do()
        {
            int[] nums = new int[] { 0, 0, 1, 1, 2, 3, 4, 4 };

            if (nums.Length == 0) return 0;
            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[number])
                {
                    number++;
                    nums[number] = nums[i];
                }
            }

            number += 1;
            return number;
        }
    }
}
