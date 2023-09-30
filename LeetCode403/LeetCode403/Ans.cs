

namespace LeetCode403
{
    public static class Ans
    {
        public static bool CanCross(int[] nums)
        {
            int max = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] <= max + 1 && nums[i + 1] - nums[i]>=max-1)
                {
                    if (nums[i + 1] - nums[i] == 0) return false;
                    max = nums[i + 1] - nums[i];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
