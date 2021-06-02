using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert
{
    public static class ValidateSubsequence {
        // O(n) time | O(1) space - where n is the length of the array
        // var array = new List<int> { 3, 5, -4, 8, 11, 1, -1, 6 };
        // var sequence = new List<int> { 5, 8, 1, -1 }; ;
        public static bool IsValidSubsequence1(List<int> array, List<int> sequence) {
            int arrIdx = 0; int seqIdx = 0;
            while (arrIdx < array.Count && seqIdx < sequence.Count) {
                if (array[arrIdx] == sequence[seqIdx]) {
                    seqIdx += 1;
                }
                arrIdx += 1;
            }
            return seqIdx == sequence.Count;
        }
        public static bool IsValidSubsequence2(List<int> array, List<int> sequence) {
            int seqIdx = 0;
            foreach (var item in array) {
                if (seqIdx == sequence.Count) {
                    break;
                }
                if (sequence[seqIdx] == item) {
                    seqIdx += 1;
                }
            }
            return seqIdx == sequence.Count;
        }
    }
}
