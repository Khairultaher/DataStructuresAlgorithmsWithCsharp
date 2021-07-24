using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class StringToInteger
    {
        public static string str = "987";

        public static void Convert()
        {
            str = str.Trim();
            if (str.Length == 0) return;

            //The first digit is not a number or a sign, directly return 0
            if (!char.IsDigit(str[0]) && str[0] != '-' && str[0] != '+') return;

            // Intercept the previous number string
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    str = str.Substring(0, i);
                    break;
                }
            }
            //There are only symbols left, return 0 directly 
            if (str == "-" || str == "+" || str == "+-" || str == "-+") return;
            //Normal number seeking result
            int result = 0;
            if (int.TryParse(str, out int tryResult2))
            {
                result = tryResult2;
            }
            else
            {
                if (str.Contains("-")) result = int.MinValue;
                else result = int.MaxValue;
            }
            Console.WriteLine(result);
            //return result;
        }
    }
}
