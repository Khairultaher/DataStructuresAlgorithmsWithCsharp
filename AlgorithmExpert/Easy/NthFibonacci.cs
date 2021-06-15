using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public static class NthFibonacci
    {
        public static int GetNthFibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
            }

        }


    }
}
