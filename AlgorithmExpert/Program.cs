using System;
using System.Collections.Generic;

namespace AlgorithmExpert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TwoNumberSum
            //int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            //var target = 10;
            //foreach (var item in TwoNumberSum.TwoNumberSum2(array, target))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ValidateSubsequence
            var array = new List<int> { 3, 5, -4, 8, 11, 1, -1, 6 };
            var sequence = new List<int> { 5, 8,1, -1 }; ;
            //var res = ValidateSubsequence.IsValidSubsequence1(array, sequence);
            var res = ValidateSubsequence.IsValidSubsequence2(array, sequence);
            Console.WriteLine(res);
            #endregion


            Console.ReadLine();
        }
    }
}
