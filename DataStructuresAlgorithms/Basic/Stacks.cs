using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    class StacksArray
    {
        int[] data;
        int top;

        public StacksArray(int n)
        {
            data = new int[n];
            top = 0;
        }

        public int length()
        {
            return top;
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public bool isFull()
        {
            return top == data.Length;
        }

        public void push(int e)
        {
            if (isFull())
            {
                Console.WriteLine("Stack if Full/Overflow");
                return;
            }
            else
            {
                data[top] = e;
                top = top + 1;
            }
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty/UnderFlow");
                return -1;
            }
            int e = data[top - 1];
            top = top - 1;
            return e;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return data[top - 1];
        }

        public void display()
        {
            for (int i = 0; i < top; i++)
                Console.Write(data[i] + "--");
            Console.WriteLine();
        }
    }
    public class StacksLinked
    {
        Node top;
        int size;

        public StacksLinked()
        {
            top = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void push(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size = size + 1;
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int e = top.element;
            top = top.next;
            size = size - 1;
            return e;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.element;
        }

        public void display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}
