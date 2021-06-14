using AlgorithmExpert.Easy;
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

            BinaryTree binaryTree = new BinaryTree(1);
            Console.ReadLine();
        }


        public static int BynarySearch(int[] arr, int target)
        {
            Array.Sort(arr);
            int min = 0; int max = arr.Length - 1;
            while (min <= max)
            {
                int middle = (min + max) / 2;
                int match = arr[middle];
                if (target == match)
                {
                    return arr[middle];
                }

                if (target > arr[middle])
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }

            return -1;
        }

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

        public static int[] BubbleSort(int[] arr)
        {

            int n = arr.Length - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                var temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
