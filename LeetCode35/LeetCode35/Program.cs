namespace LeetCode35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            Ans.SearchInsert(nums, 8);
        }
        public static class Ans
        {
            public static int SearchInsert(int[] nums, int target)
            {
                return BinarySearching(nums, 0, nums.Length - 1, target);

            }
            private static int BinarySearching(int[] nums, int left, int right, int target)
            {
                if (left > right) return left;

                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                if (target < nums[mid]) return BinarySearching(nums, left, mid - 1, target);
                return BinarySearching(nums, mid + 1, right, target);
            }
        }
    }
}