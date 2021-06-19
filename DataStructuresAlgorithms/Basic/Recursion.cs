using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public static class Recursion
    {
        public static void CalculateIterative(int num)
        {
            while (num > 0)
            {
                int val = num * num;
                Console.WriteLine(val);
                num = num - 1;
            }
        }

        public static void CalculateRecursion(int num)
        {
            if (num > 0)
            {
                // Head Recursion
                CalculateRecursion(num - 1);

                int val = num * num;
                Console.WriteLine(val);

                // Tail Recursion
                //CalculateRecursion( num - 1);
            }
        }

        public static int SumOfnNumber(int n)
        {
            return (n * (n + 1)) / 2;
        }
        public static int SumOfnNumberIterative(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i++;
            }
            return total;
        }

        public static int SumOfnRecursive(int n)
        {
            if (n == 0) return 0;

            return n + SumOfnRecursive(n -1);
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 0) return 1;

            return n * FactorialRecursive(n - 1);
        }
        public static int FactorialIterative(int n)
        {
            int factorial = 1;
            while (n >= 1)
            {
                factorial = factorial * n;
                --n;
            }

            return factorial;
        }
    }
}
