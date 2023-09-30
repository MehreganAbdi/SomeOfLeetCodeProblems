using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode74
{
    public static class Ans
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            bool ans = false;
            for (int i = 0; i < matrix.Length; i++) 
            {
                foreach (var item in matrix[i])
                {
                    if(target == item)
                    {
                        ans = true;
                    }
                }
            }

            return ans;
        }
    }
}
