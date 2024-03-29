﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ClosestValueInBST
    {
        public static int FindClosestValueInBst(BST tree, int target)
        {
            return FindClosestValueInBst1(tree, target, Int32.MaxValue);
        }

        // Avarage: O(log(n)) time | O(log(n)) space
        // Wrost: O(n) time | O(n) space
        public static int FindClosestValueInBst1(BST tree, int target, double closest)
        {
            if (Math.Abs(target - closest) > Math.Abs(target - tree.Value))
            {
                closest = tree.Value;
            }

            if (closest > tree.Value)
            {
                return FindClosestValueInBst1(tree.Right, target, closest);
            }
            else if (closest < tree.Value)
            {
                return FindClosestValueInBst1(tree.Left, target, closest);
            }
            else
            {
                return (int)closest;
            }
        }

        // Avarage: O(log(n)) time | O(1) space
        // Wrost: O(n) time | O(1) space
        public static int FindClosestValueInBst2(BST tree, int target, double closest)
        {
            BST currentNode = tree;
            while (currentNode != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.Value)) {
                    closest = currentNode.Value;
                }
                if (target < currentNode.Value){
                    currentNode = currentNode.Left;
                }
                else if (target > currentNode.Value) {
                    currentNode = currentNode.Right;
                }
                else {
                    break;
                }              
            }
            return (int)closest;
        }

    }
    public class BST {
        public int Value;
        public BST Left;
        public BST Right;
        public BST(int value) {
            this.Value = value;
        }
    }
}
