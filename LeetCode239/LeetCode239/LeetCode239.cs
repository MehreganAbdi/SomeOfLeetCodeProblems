using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode239
{
    public static class LC239
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            
            LinkedList<int> queue = new LinkedList<int>();

            List<int> result = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                while (queue.Count > 0 && queue.First.Value < i - k + 1)
                {
                    queue.RemoveFirst();
                }

                var currentVal = nums[i];
                while (queue.Count > 0 && nums[queue.Last.Value] < currentVal)
                    queue.RemoveLast();

                queue.AddLast(i);

                if (i >= k - 1)
                    result.Add(nums[queue.First.Value]);
            }

            return result.ToArray();
        }
    }
}