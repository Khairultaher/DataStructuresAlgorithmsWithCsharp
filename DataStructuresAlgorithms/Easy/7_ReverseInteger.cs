using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ReverseInteger
    {
        public static int x = -1230;

        public static void Reverse()
        {
            if (x == int.MinValue) 
                return; 
            // Math.Abs(int.MinValue) will make an error; because int.MinValue overflows after inversion, it can be judged in advance
            int flag = x > 0 ? 1 : -1; // Take out the symbol
            var chars = Math.Abs(x).ToString().ToCharArray();
            Array.Reverse(chars);
            var reversedStr = new string(chars);
            var result = 0;
            if (int.TryParse(reversedStr, out int parseOkResult))
            {
                result = parseOkResult;
            };

            Console.WriteLine(result* flag);
        }
    }
}



