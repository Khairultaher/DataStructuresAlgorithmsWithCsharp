using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        // O(1) time | O(1) space
        public void SetHead(Node node)
        {
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
                return;
            }
            InsertBefore(this.Head, node);
        }
        // O(1) time | O(1) space
        public void SetTail(Node node)
        {
            if (this.Tail == null)
            {
                SetHead(node);
                return;
            }
            InsertAfter(Tail, node);
        }       
        // O(1) time | O(1) space
        public void InsertBefore(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == this.Head && nodeToInsert == this.Tail) return;
            Remove(nodeToInsert);
            nodeToInsert.Prev = node.Prev;
            nodeToInsert.Next = node;
            if (node.Prev == null)
            {
                this.Head = nodeToInsert;
            }
            else
            {
                node.Prev.Next = nodeToInsert;
            }
            node.Prev = nodeToInsert;
        }
        // O(1) time | O(1) space
        public void InsertAfter(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == this.Head && nodeToInsert == this.Tail) return;
            Remove(nodeToInsert);
            nodeToInsert.Prev = node;
            nodeToInsert.Next = node.Next;
            if (node.Next == null)
            {
                this.Tail = nodeToInsert;
            }
            else
            {
                node.Next.Prev = nodeToInsert;
            }
        }
        // O(p) time | O(1) space
        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            if (position == 1)
            {
                SetHead(nodeToInsert);
                return;
            }
            var node = this.Head;
            var currentPosition = 1;
            while (node !=null && currentPosition != position)
            {
                node = node.Next;
                currentPosition += 1;
            }
            if (node != null)
            {
                InsertBefore(node, nodeToInsert);
            }
            else
            {
                InsertAfter(node, nodeToInsert);
            }

        }
        // O(n) time | O(1) space
        public void RemoveNodeWithValue(string value)
        {
            var node = this.Head;
            while (node != null)
            {
                var nodeToRemove = node;
                node = node.Next;
                if (nodeToRemove.Value == value)
                {
                    Remove(nodeToRemove);
                }
            }
        }
        // O(1) time | O(1) space
        public void Remove(Node node)
        {
            if (node == this.Head)
            {
                this.Head = this.Head.Next;
            }
            if(node == this.Tail)
            {
                this.Tail = this.Tail.Prev;
            }

            RemoveNodeBindings(node);
        }
        public void RemoveNodeBindings(Node node)
        {
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            
            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
            node.Prev = null;
            node.Next = null;
        }
        // O(n) time | O(1) space
        public bool ContainNodeWithValue(string value)
        {
            var node = this.Head;
            while (node != null && node.Value != value)
            {
                node = node.Next;
            }

            return (node != null);
        }
        public class Node
        {
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public string Value { get; set; }
        }
    }

}