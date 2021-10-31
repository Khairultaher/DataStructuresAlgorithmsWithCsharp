using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        // Iterative Search
        public bool search(int key)
        {
            Node temproot = root;
            while (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    temproot = temproot.left;
                else if (key > temproot.element)
                    temproot = temproot.right;
            }
            return false;
        }

        // Recursive Search
        public bool search(Node temproot, int key)
        {
            if (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    return search(temproot.left, key);
                else if (key > temproot.element)
                    return search(temproot.right, key);
            }
            return false;
        }
        
        // Iterative Insert
        public void IterativeInsert(Node temproot, int e)
        {
            Node temp = null;
            while (temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if (e > temproot.element)
                    temproot = temproot.right;
            }
            Node n = new Node(e, null, null);
            if (root != null)
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            else
                root = n;
        }

        // Recursive Insert
        public Node RecursiveInsert(Node temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = RecursiveInsert(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = RecursiveInsert(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }

        public bool Delete(int e)
        {
            Node p = root;
            Node pp = null;

            // find the node to be deleted
            while (p != null && p.element != e)
            {
                pp = p;
                if (e < p.element)
                    p = p.left;
                else
                    p = p.right;
            }

            if (p == null)
                return false;

            if (p.left != null && p.right != null)
            {
                Node s = p.left;
                Node ps = p;
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element;
                p = s;
                pp = ps;
            }

            Node c = null;
            if (p.left != null)
                c = p.left;
            else
                c = p.right;

            if (p == root)
                root = null;
            else
            {
                if (p == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }
            return true;
        }

        public Node DeleteRecurcive(Node root, int e)
        {
            if (root is null) return root;

            // find out the to be deleted
            if (e > root.left.element)
            {
                root.right = DeleteRecurcive(root.right, e);
            }
            else if (e < root.right.element)
            {
                root.left = DeleteRecurcive(root.left, e);
            }
            else //else we found the key
            {
                //case 1: Node to be deleted has no children
                if (root.left == null && root.right == null)
                {
                    //update root to null
                    root = null;
                }
                //case 2 : node to be deleted has two children
                else if (root.left != null && root.right != null)
                {
                    Node maxNode = root.right;
                    while (maxNode.left != null)
                    {
                        maxNode = maxNode.left;
                    }
                    //copy the value
                    root.element = maxNode.element;
                    root.right = DeleteRecurcive(root.right, maxNode.element);
                }
                //node to be deleted has one children
                else
                {
                    var child = root.left != null ? root.left : root.right;
                    root = child;
                }
            }
            return root;
        }
        public void inorder(Node temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }

        public void postorder(Node temproot)
        {
            if (temproot != null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }

        public void levelorder()
        {
            QueuesLinked q = new QueuesLinked();
            Node t = root;
            Console.Write(t.element + " ");
            q.enqueue(t);
            while (!q.isEmpty())
            {
                t = (Node)q.dequeue();
                if (t.left != null)
                {
                    Console.Write(t.left.element + " ");
                    q.enqueue(t.left);
                }
                if (t.right != null)
                {
                    Console.Write(t.right.element + " ");
                    q.enqueue(t.right);
                }
            }
        }

        public int count(Node temproot)
        {
            if (temproot != null)
            {
                int x = count(temproot.left);
                int y = count(temproot.right);
                return x + y + 1;
            }
            return 0;
        }

        public int height(Node temproot)
        {
            if (temproot != null)
            {
                int x = height(temproot.left);
                int y = height(temproot.right);
                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }

        public class QNode
        {
            public Object element;
            public QNode next;
            public QNode(Object e)
            {
                element = e;
                next = null;
            }
        }

        public class QueuesLinked
        {
            QNode front;
            QNode rear;
            int size;

            public QueuesLinked()
            {
                front = null;
                rear = null;
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

            public void enqueue(Object e)
            {
                QNode newest = new QNode(e);
                if (isEmpty())
                    front = newest;
                else
                    rear.next = newest;
                rear = newest;
                size = size + 1;
            }

            public Object dequeue()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }
                Object e = front.element;
                front = front.next;
                size = size - 1;
                if (isEmpty())
                    rear = null;
                return e;
            }

            public void display()
            {
                QNode p = front;
                while (p != null)
                {
                    Console.Write(p.element + " --> ");
                    p = p.next;
                }
                Console.WriteLine();
            }

        }

        // Node Class
        public class Node
        {
            public int element;
            public Node left;
            public Node right;

            public Node(int e, Node l, Node r)
            {
                element = e;
                left = l;
                right = r;
            }
        }
    }
}
