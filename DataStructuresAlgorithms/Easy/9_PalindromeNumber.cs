using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome2(int x)
        {
            string str = x.ToString();
            int leftIdx = 0;
            int rightIdx = str.Length - 1;
            while (leftIdx < rightIdx)
            {
                if (str[leftIdx] != str[rightIdx])
                {
                    return false;
                }
                leftIdx++;
                rightIdx--;
            }
            return true;
        }
    }
}
