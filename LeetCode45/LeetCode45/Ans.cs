using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode45
{
    public static class Ans
    {
        public static int Jump(int[] nums)
        {
            int min = 0, max = 0, totalSteps = 0;
            while (max < nums.Length - 1)
            {
                int LastHome = 0;
                for (int i = min; i <= max; i++)
                {
                    LastHome = Math.Max(LastHome, i + nums[i]);
                }

                min = max + 1;
                max = LastHome;
                totalSteps++;
            }
            return totalSteps;
        }
    }
}
