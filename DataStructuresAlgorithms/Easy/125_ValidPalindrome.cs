using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ValidPalindrome
    {
        // O(n) time | O(1) space
        public static bool IsPalindrome2(string s)
        {
            if (String.IsNullOrEmpty(s)) return true;

            var start = 0; var end = s.Length - 1;
            while (start < end)
            {
                if (!Char.IsLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }

                if (!Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }
            return true;
        }
    }
}
