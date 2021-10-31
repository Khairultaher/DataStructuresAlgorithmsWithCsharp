using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public static class Sorting
    {

        // O(n^2)
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

        // O(n^2)
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

        // O(n^2)
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


        // O(nlog(n))
        public static void MergeSort(this int[] array)
        {
            MergeSortHelper(array, 0, array.Length - 1);
        }
        public static void MergeSortHelper(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(A, left, mid);
                MergeSortHelper(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }
        public static void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;

            int k = left;
            int[] B = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }

            for (int x = left; x < right + 1; x++)
            {
                A[x] = B[x];
            }
        }
        
        // O(nlog(n))
        public static void MergeSort2(List<int> unsorted)
        {
            if (unsorted.Count > 1)
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                int middle = unsorted.Count / 2;
                // left = unsorted.Skip(0).Take(middle).ToList();
                for (int i = 0; i < middle; i++)  //Dividing the unsorted list
                {
                    left.Add(unsorted[i]);
                }
                // left = unsorted.Skip(middle).ToList();
                for (int i = middle; i < unsorted.Count; i++)
                {
                    right.Add(unsorted[i]);
                }

                MergeSort2(left);
                MergeSort2(right);
                Merge2(left, right);
            }
            
        }
        public static List<int> Merge2(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
