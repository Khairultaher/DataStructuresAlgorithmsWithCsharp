using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public class MergeTwoSortedLists
    {
        public Basic.LinkedList l1 = new Basic.LinkedList();
        public Basic.LinkedList l2 = new Basic.LinkedList();
        public int a = 0;
        public MergeTwoSortedLists()
        {
            //l1 = ((Func<Basic.LinkedList>)(()=> {
            //    Basic.LinkedList ll1 = null;
            //    return ll1;
            //}))();
            foreach (var item in new int[] { 1, 2, 4})
            {
                l1.AddLast(item);
            }

            foreach (var item in new int[] { 1, 3, 4 })
            {
                l2.AddLast(item);
            }
        }

        public ListNode Merge(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode head = (l1.val < l2.val) ? l1 : l2;
            ListNode tail = (l1.val < l2.val) ? l2 : l1;
            head.next = Merge(head.next, tail);
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public int size = 0;
        public ListNode(int x) 
        { 
            val = x; 
        }


        public bool IsEmpty()
        {
            return size == 0;
        }

    }
}
