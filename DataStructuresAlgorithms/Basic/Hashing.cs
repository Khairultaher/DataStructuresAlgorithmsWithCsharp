using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public class HashChain
    {
        int hashtablesize;
        LinkedList[] hashtable;

        public HashChain()
        {
            hashtablesize = 10;
            hashtable = new LinkedList[hashtablesize];
            for (int i = 0; i < hashtablesize; i++)
                hashtable[i] = new LinkedList();
        }

        public int HashCode(int key)
        {
            return key % hashtablesize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            hashtable[i].insertsorted(element);
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            return hashtable[i].search(key) != -1;
        }

        public void Display()
        {
            for (int i = 0; i < hashtablesize; i++)
            {
                Console.Write("[" + i + "]");
                hashtable[i].display();
            }
            Console.WriteLine();
        }

        static void Test()
        {
            HashChain h = new HashChain();
            h.Insert(54);
            h.Insert(78);
            h.Insert(64);
            h.Insert(92);
            h.Insert(34);
            h.Insert(86);
            h.Insert(28);
            h.Display();
            Console.WriteLine("Element Found: " + h.Search(44));
        }
    }

    public class HashLinearProbe
    {
        int hashtablesize;
        int[] hashtable;

        public HashLinearProbe()
        {
            hashtablesize = 10;
            hashtable = new int[hashtablesize];
        }

        public int HashCode(int key)
        {
            return key % hashtablesize;
        }

        public int Lprobe(int element)
        {
            int i = HashCode(element);
            int j = 0;
            while (hashtable[(i + j) % hashtablesize] != 0)
                j = j + 1;
            return (i + j) % hashtablesize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            if (hashtable[i] == 0)
                hashtable[i] = element;
            else
            {
                i = Lprobe(element);
                hashtable[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            int j = 0;
            while (hashtable[(i + j) % hashtablesize] != key)
            {
                if (hashtable[(i + j) % hashtablesize] == 0)
                    return false;
                j = j + 1;
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < hashtablesize; i++)
                Console.Write(hashtable[i] + " ");
            Console.WriteLine();
        }

        static void Test()
        {
            HashLinearProbe h = new HashLinearProbe();
            h.Insert(54);
            h.Insert(78);
            h.Insert(64);
            h.Insert(92);
            h.Insert(34);
            h.Insert(86);
            h.Insert(28);
            h.Display();
            Console.WriteLine("Element Found: " + h.Search(44));
        }
    }
}
