﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public class Node
    {
        public Node prev;
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }

        public Node(int e, Node n, Node p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }
        public void AddLast(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                tail = newest;
            }

            size = size + 1;
        }
        public void AddAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (IsEmpty())
                    tail = null;
                return e;
            }
        }
        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }
        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;
        }
        public int Search(int key)
        {
            Node p = head;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;
                index = index + 1;
            }
            return -1;
        }
        public void InsertSorted(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
                head = newest;
            else
            {
                Node p = head;
                Node q = head;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }
        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
