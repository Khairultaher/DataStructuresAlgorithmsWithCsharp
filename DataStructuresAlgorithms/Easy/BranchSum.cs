using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
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
}
