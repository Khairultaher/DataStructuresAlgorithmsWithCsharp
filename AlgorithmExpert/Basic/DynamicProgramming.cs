using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Basic
{
    public class DynamicProgramming
    {
        // Memoization
        public static long GetNthFibonacciMemo(int n)
        {
            long[] arr = new long[n + 1];
            long res = 0;
            if (arr[n] == 0)
            {
                if ((n == 0) || (n == 1))
                {
                    res = n;
                }
                else
                {
                    res = GetNthFibonacciMemo(n - 1) + GetNthFibonacciMemo(n - 2);
                }
                arr[n] = res;
            }

            return arr[n];
        }

        // Tabulation
        public static long GetNthFibonacciTabu(int n)
        {
            long[] arr = new long[n + 1];
            arr[0] = 0; arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr[n];
        }
    }
}
