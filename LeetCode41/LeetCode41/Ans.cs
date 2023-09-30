
namespace LeetCode41
{
    public static class Ans
    {
        public static int FirstMissingPositive(int[] nums)
        {
            int min = nums.Min();
            
            _ = min < 0 ? nums[Array.IndexOf(nums, min)] = 0 : min;
            if (min < 0)
            {
                min = 0;
            }
            int max = nums.Max();
            Array.Sort(nums);

            int ans = -1;
            for(int i = min ; i< max&& ans==-1 ; i++)
            {
                for(int j = Array.IndexOf(nums,min); j < nums.Length && ans==-1; j++)
                {
                    if (nums[j] >min && nums[j+1] - nums[j] > 1)
                    {
                        ans =  nums[j]+1;
                    }
                    
                }
            }

            if(ans==-1 && min == 0)
            {
                ans = max + 1;
            }else if(ans==-1 && min > 0)
            {
                ans = min - 1;
            }

            return ans;
        }

    }
}
