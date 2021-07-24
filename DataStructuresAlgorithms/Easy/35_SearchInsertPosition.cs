using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class SearchInsertPosition
    {
        public static int Search()
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 2;

            if (nums[0] > target)
            {
                return 0;
            }
            else if (nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] < target && nums[i + 1] > target)
                {
                    return i + 1;
                }
                else if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i + 1] == target)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
