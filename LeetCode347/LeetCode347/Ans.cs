using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode347
{
    public static class Ans
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var Dict  = new Dictionary<int, int>();
            Array.Sort(nums);
            
            
            for(int i = 0; i< nums.Length; i++)
            {
                if (i>0 && nums[i] == nums[i - 1])
                {
                    Dict[nums[i-1]]++;
                }
                else
                {
                    Dict.Add(nums[i], 1);
                }
            }
            var array = new int[k];



            var pQ = new PriorityQueue<int, int>();
            foreach (var key in Dict.Keys)
            {
                pQ.Enqueue(key, Dict[key]);
                if (pQ.Count > k) pQ.Dequeue();
            }
            int i2 = k;
            while (pQ.Count > 0)
            {
                array[--i2] = pQ.Dequeue();
            }
            return array;

        }
    }
}
