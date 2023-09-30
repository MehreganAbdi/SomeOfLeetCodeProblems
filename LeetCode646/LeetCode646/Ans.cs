

namespace LeetCode646
{
    public static class Ans
    {
        public static int FindLongestChain(int[][] pairs)
        {
            int longest = 0;
            int current = int.MaxValue;
            Array.Sort(pairs,(a,b) => a[1].CompareTo(b[1]));

            foreach (var item in pairs)
            {
                if (item[0] < current)
                {
                    longest++;
                    current = item[1];
                }
            }

            return longest;
        }
    }
}
