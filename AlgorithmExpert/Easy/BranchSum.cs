using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public  class BranchSum {
        public List<int> BranchSums(BinaryTree root) {
            List<int> sums = new List<int>();
            CalculateBranchSums(root, 0, sums);
            return sums;
        }

        private void CalculateBranchSums(BinaryTree node, int runningSum, List<int> sums) {
            if (node is null) {
                return;
            }
            int newRuningSum = runningSum + node.Value;
            if (node.Left is null && node.Right is null) {
                sums.Add(node.Value);
                return;
            }

            CalculateBranchSums(node.Left, newRuningSum, sums);
            CalculateBranchSums(node.Right, newRuningSum, sums);
        }
    }

    public class BinaryTree {
        public BinaryTree(int value) {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
        public int Value { get; private set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
    }
}
