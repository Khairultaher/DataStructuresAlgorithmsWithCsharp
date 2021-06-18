using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public static class NodeDepth
    {
        // Average case: when the tree is balanced
        // O(n) time | O(h) space - where n is the number of nodes in
        // the Binary Tree and h is the height of the Binary Tree
        public static int GetNodeDepth(BinaryTree root)
        {
            int sumOfDepth = 0;
            Stack<Level> stack = new Stack<Level>();
            stack.Push(new Level(root, 0));

            while (stack.Count > 0)
            {
                Level top = stack.Pop();
                BinaryTree node = top.Root;
                int depth = top.Depth;

                if (node == null) continue;

                sumOfDepth += depth;

                stack.Push(new Level(node.Left, depth + 1));
                stack.Push(new Level(node.Right, depth + 1));

            }
            return sumOfDepth;
        }

        // Average case: when the tree is balanced
        // O(n) time | O(h) space - where n is the number of nodes in
        // the Binary Tree and h is the height of the Binary Tree
        public static int GetNodeDepthRecur(BinaryTree root)
        {
            return NodeDepthHelper(root, 0);
        }
        public static int NodeDepthHelper(BinaryTree root, int depth)
        {
            if (root == null) return 0;

            return depth 
                + NodeDepthHelper(root.Left, depth + 1) 
                + NodeDepthHelper(root.Right,depth + 1);
        }

    }
}
