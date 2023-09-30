using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode33
{
    public static class Ans
    {
        public static int Search(int[] nums, int target)
        {
            int ans = -2;
            if (!nums.Contains(target))
            {
                ans = -1;
            }
            else
            {

                for (int i = nums.Length - 1; ans == -2 && i >= 0; i--)
                {
                    if (i > 0 && nums[i] < nums[i - 1] && nums[i] == target)
                    {
                        ans = i;
                    }
                    else if (nums[i] == target)
                    {
                        ans = i;
                    }
                    else if (nums[i - 1] == target && i > 0)
                    {
                        ans = i - 1;
                    }
                }

            }
            return ans;
        }
    }
}
