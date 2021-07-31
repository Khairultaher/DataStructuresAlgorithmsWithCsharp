using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class RomanToInteger
    {
        public static string s = "MCMXCIV";
        //Output: 1994
        //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

        public static void RomanToInt()
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += RomanToIntHelper(s, i, map) * map[s[i]];
            }
            //return sum;
            Console.WriteLine(sum);
        }
        public static int RomanToIntHelper(string s, int i, Dictionary<char, int> map)
        {
            if (i == s.Length - 1) return 1;

            else if (map[s[i]] < map[s[i + 1]])
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
