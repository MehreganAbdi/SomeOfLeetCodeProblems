using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode767
{
    public static class Ans
    {
       
        public static int ToRoman(string input)
        {
            Dictionary<char, int> myDic = new Dictionary<char, int>() { { 'I' , 1 } , { 'V' , 5 } , { 'X' , 10 }
            ,{ 'L' , 50 } , { 'C' , 100 } , { 'D' , 500 } , { 'M' , 1000}};
            List<int> nums = new List<int>();

            string order = "IVXLCDM";
            int ans = 0;
            int l = 0;
            int r = 1;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (order.IndexOf(input[i]) <= order.IndexOf(input[i + 1]))
                {
                    r++;
                }
                else if(order.IndexOf(input[i]) > order.IndexOf(input[i + 1]))
                {
                    int sum = myDic[input[r]];
                    for(int j = l; j<r; j++)
                    {
                         sum = sum - (myDic[input[j]]);
                        nums.Add(sum);
                    }
                    l = r + 1;
                    r = l + 1; 
                }
            }

            for(int k = nums.Count-1; k >= 0; k--)
            {
                ans = ans + nums[nums.Count - 1 - k] * (int)Math.Pow(10, k );
            }



            return ans; 
        }

    }
}
