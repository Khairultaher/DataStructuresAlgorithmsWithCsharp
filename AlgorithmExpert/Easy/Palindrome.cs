using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public static class Palindrome
    {
        // O(n) time | O(n) space
        public static bool IsPalindrome1(string str)
        {
            StringBuilder reversedstring = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedstring.Append(str[i]);
            }
            return str.Equals(reversedstring.ToString());
        }

        // O(n) time | O(1) space
        public static bool IsPalindrome2(string str)
        {
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
