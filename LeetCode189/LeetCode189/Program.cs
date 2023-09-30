namespace LeetCode189
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Ans.Rotate(nums, 3);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}