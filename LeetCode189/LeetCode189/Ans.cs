using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode189
{
    public static class Ans
    {
        public static void Rotate(int[] nums, int k)
        {
            Array.Reverse(nums);

            k = k % nums.Length; 

            int[] helper = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                if(i < k)
                {
                    helper[i] = nums[k - 1 - i];
                }
                else
                {
                    helper[i] = nums[nums.Length - 1 - (i-k)];
                }
            
            
            }
            Array.Copy(helper, nums, nums.Length);
        }
    }
}
