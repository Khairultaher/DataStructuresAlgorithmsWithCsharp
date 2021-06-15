using AlgorithmExpert.Easy;
using System;
using System.Collections.Generic;
using AlgorithmExpert.Basic;

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

            #region Sorting/Searching
            List<int> arr = new List<int> { 6, 4, 5, 3, 2, 7, 1 };
            var res1 = Sorting.MergeSort(arr);
            #endregion

            Console.ReadLine();
        }
    }
}
