using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class LongestCommonPrefix
    {
        public static string[] strs = new string[] { "flower", "flow", "flight" };
        public static void Get()
        {
            if (strs.Length == 0 || strs[0] == "") return;

            string com = strs[0];// Initialize the first string for the collation object
            int len = strs.Length;// string of length
            int clen = com.Length;// first string length
            for (int i = 0; i < clen; i++)// loop through each character
            {
                char c = com[i];
                for (int j = 1; j < len; j++) //In addition to the string // traverse the outside of the first string (because there is no comparison with their own)
                {
                    string temp = strs[j];
                    if (i == strs[j].Length || temp[i] != c)
                        //return com.Substring(0, i);// if i reach than the last character of the object and returns the result, otherwise it will exceed the range
                        Console.WriteLine(com.Substring(0, i));
                }
            }
            //return com;
            Console.WriteLine(com);
        }
    }
}
