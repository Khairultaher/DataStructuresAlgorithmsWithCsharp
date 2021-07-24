using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class RemoveElement
    {
        public static int Do()
        {
            int[] nums = { 0, 1, 3, 3, 4, 3, 5 };
            int val = 3;

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}
