using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public class Heap
    {
        int[] data;
        int maxsize;
        int csize;

        public Heap()
        {
            maxsize = 10;
            data = new int[maxsize];
            csize = 0;
            for (int i = 0; i < data.Length; i++)
                data[i] = -1;
        }
        public int Length()
        {
            return csize;
        }
        public bool IsEmpty()
        {
            return csize == 0;
        }
        public void Insert(int e)
        {
            if (csize == maxsize)
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            csize = csize + 1;
            int hi = csize;
            while (hi > 1 && e > data[hi / 2])
            {
                data[hi] = data[hi / 2];
                hi = hi / 2;
            }
            data[hi] = e;
        }
        public int Max()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1];
        }
        public int DeleteMax()
        {
            if (csize == 0)
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int e = data[1];
            data[1] = data[csize];
            data[csize] = -1;
            csize = csize - 1;
            int i = 1;
            int j = i * 2;
            while (j <= csize)
            {
                if (data[j] < data[j + 1])
                    j = j + 1;
                if (data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i = j;
                    j = i * 2;
                }
                else
                    break;
            }
            return e;
        }
        public void Heapsort(int[] A, int n)
        {
            Heap h = new Heap();
            for (int i = 0; i < n; i++)
                h.Insert(A[i]);
            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                A[k] = h.DeleteMax();
                k = k - 1;
            }
        }
        public void Display()
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write(data[i] + " ");
            Console.WriteLine();
        }
        public void Test()
        {
            Heap h = new Heap();
            h.Insert(25);
            h.Insert(14);
            h.Insert(2);
            h.Insert(20);
            h.Insert(10);
            h.Display();
            h.Insert(40);
            h.Display();
            Console.ReadKey();
        }
    }
}
