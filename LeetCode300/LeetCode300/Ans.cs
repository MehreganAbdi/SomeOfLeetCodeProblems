using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode300
{
    public class Ans
    {
        public static int LengthOfLIS(int[] nums)
        {
            int[] list = new int[nums.Length];



            for (int i = nums.Length - 1; i >= 0; i--)
            {
                list[i] = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] < nums[j] && list[i] < 1 + list[j])
                    {
                        list[i] = list[j] + 1;
                    }

                }
            }


            return list.Max();
        }
    }
}
