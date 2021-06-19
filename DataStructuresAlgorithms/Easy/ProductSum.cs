using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Easy
{
    public static class ProductSum
    {
        // O(n) time | O(d) space - where n is the total number of elements
        // including sub-elements, and d is the greatest depth of "special"
        public static int GetProductSum(List<object> array)
        {
            return ProductSumHelper(array, 1);
        }

        public static int ProductSumHelper(List<object> array, int multiplier)
        {
            int sum = 0;
            foreach (object el in array)
            {
                if (el is IList<object>)
                {
                    sum += ProductSumHelper((List<object>)el, multiplier + 1);
                }
                else
                {
                    sum += (int)el;
                }
            }
            return sum * multiplier;
        }
    }
}
