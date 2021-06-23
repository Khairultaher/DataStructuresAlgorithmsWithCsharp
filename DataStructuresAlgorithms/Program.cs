using DataStructuresAlgorithms.Easy;
using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Basic;


namespace DataStructuresAlgorithms
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
            //var res = ValidateSubsequence.IsValidSubsequence2(array, sequence);
            //Console.WriteLine(res);
            #endregion

            #region Dynamic Programing
            //var res = NthFibonacci.GetNthFibonacciMemo(6);

            #endregion

            #region Caesar Cipher Encryptor 
            //String text = "ATTACKATONCE";
            //int s = 4;
            //// EXXEGOEXSRGI
            //var res = CaesarCipherEncryptor.Encrypt(text, s);

            #endregion

            #region Recursion
            //var res = Recursion.FactorialIterative(5);
            #endregion

            #region Sorting/Searching
            //List<int> arry = new List<int> { 6, 4, 5, 3, 2, 7, 1 };
            //arry.MergeSort2();
            //foreach (var item in arry)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LinkList
            //LinkedList l = new LinkedList();
            //l.addLast(7);
            //l.addLast(4);
            //l.addLast(12);
            //l.addLast(8);
            //l.addLast(3);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            //l.addAny(20, 3);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            //l.addAny(40, 5);
            //l.display();
            //Console.WriteLine("Size: " + l.length());

            #endregion

            #region CircularLinkedList
            CircularLinkedList l = new CircularLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int element = l.removeAny(3);
            Console.WriteLine("Removed Element: " + element);
            l.display();
            Console.WriteLine("Size: " + l.length());
            #endregion

            Console.ReadLine();
        }
    }
}
