using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ImplementStr
    {
        public static int Str()
        {
            string haystack = "hello", needle = "ll";
            if (needle == "") return 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                int j = 0;
                while ((i + j) < haystack.Length && haystack[i + j] == needle[j])
                {
                    if (j == needle.Length - 1) return i;

                    j++;
                }
                if (i + j == haystack.Length) return -1;
            }
            return -1;
        }

    }
}
