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
            //CircularLinkedList l = new CircularLinkedList();
            //l.addLast(7);
            //l.addLast(4);
            //l.addLast(12);
            //l.addLast(8);
            //l.addLast(3);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            //int element = l.removeAny(3);
            //Console.WriteLine("Removed Element: " + element);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            #endregion

            #region DoublyLinkedList
            //Basic.DoublyLinkedList l = new Basic.DoublyLinkedList();
            //l.addLast(7);
            //l.addLast(4);
            //l.addLast(12);
            //l.addLast(8);
            //l.addLast(3);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            //int element = l.removeAny(3);
            //Console.WriteLine("Removed Element: " + element);
            //l.display();
            //Console.WriteLine("Size: " + l.length());
            #endregion

            #region StacksList
            //StacksArray s = new StacksArray(10);
            //s.push(5);
            //s.push(3);
            //s.display();
            //Console.WriteLine("Size: " + s.length());
            //Console.WriteLine("Element Popped: " + s.pop());
            //Console.WriteLine("IsEmpty: " + s.isEmpty());
            //Console.WriteLine("Element Popped: " + s.pop());
            //Console.WriteLine("IsEmpty: " + s.isEmpty());
            //s.push(7);
            //s.push(9);
            //s.display();
            //Console.WriteLine("Element Top: " + s.peek());
            //s.display();
            #endregion

            #region StacksLinked
            //StacksLinked s = new StacksLinked();
            //s.push(5);
            //s.push(3);
            //s.display();
            //Console.WriteLine("Size: " + s.length());
            //Console.WriteLine("Element Removed: " + s.pop());
            //Console.WriteLine("IsEmpty: " + s.isEmpty());
            //Console.WriteLine("Element Removed: " + s.pop());
            //Console.WriteLine("IsEmpty: " + s.isEmpty());
            //s.push(7);
            //s.push(9);
            //s.display();
            //Console.WriteLine("Element Top: " + s.peek());
            //s.display();
            #endregion

            #region QueuesArray
            //QueuesArray q = new QueuesArray(10);
            //q.enqueue(5);
            //q.enqueue(3);
            //q.display();
            //Console.WriteLine("Size: " + q.length());
            //Console.WriteLine("Element Removed: " + q.dequeue());
            //Console.WriteLine("IsEmpty: " + q.isEmpty());
            //Console.WriteLine("Element Removed: " + q.dequeue());
            //Console.WriteLine("IsEmpty: " + q.isEmpty());
            //q.enqueue(7);
            //q.enqueue(9);
            //q.enqueue(4);
            //q.display();
            //Console.WriteLine("Size: " + q.length());
            #endregion

            #region QueuesLinked
            //QueuesLinked q = new QueuesLinked();
            //q.enqueue(5);
            //q.enqueue(3);
            //q.display();
            //Console.WriteLine("Size: " + q.length());
            //Console.WriteLine("Element Removed: " + q.dequeue());
            //Console.WriteLine("IsEmpty: " + q.isEmpty());
            //Console.WriteLine("Element Removed: " + q.dequeue());
            //Console.WriteLine("IsEmpty: " + q.isEmpty());
            //q.enqueue(7);
            //q.enqueue(9);
            //q.enqueue(4);
            //q.display();
            //Console.WriteLine("Size: " + q.length());
            #endregion

            #region DeQueLinked
            //DeQueLinked d = new DeQueLinked();
            //d.addFirst(5);
            //d.addFirst(3);
            //d.addlast(7);
            //d.addlast(12);
            //d.display();
            //Console.WriteLine("Size: " + d.length());
            //Console.WriteLine("Front Element Removed: " + d.removeFirst());
            //Console.WriteLine("Rear Element Removed: " + d.removeLast());
            //d.display();
            //Console.WriteLine("First Element: " + d.first());
            //Console.WriteLine("Last Element: " + d.last());
            #endregion

            Console.ReadLine();
        }
    }
}
