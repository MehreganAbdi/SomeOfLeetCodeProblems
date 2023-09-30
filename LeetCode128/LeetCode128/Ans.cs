
namespace LeetCode128
{
    public static class Ans
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            Array.Sort(nums);
            int max = 1;
            int curr = 1;
            var set = new HashSet<int>(nums).ToArray();
            for (int j = 0; j < set.Length - 1; j++)
            {
                if (set[j+1] - set[j] == 1)
                {
                    curr++;
                    max = Math.Max(curr, max);
                }
                else
                {
                    curr = 1;
                }
            }

            return max;
        }
    }
}
