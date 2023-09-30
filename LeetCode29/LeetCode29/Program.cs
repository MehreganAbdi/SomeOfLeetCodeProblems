namespace LeetCode29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 45, 67, 33, 43, 4, 6, 754, 23 };
            //List<int> nums2 = new List<int>();
            int[] nums2 = { 1, 2, 3, 4, 5, 6, 67, 7, 6 };
            Console.WriteLine(nums.Contains(12));

            //nums2.Add(33);
            Array.Copy(nums2.ToArray(), nums, nums.Length);
            foreach(int i in nums) {
            
                Console.WriteLine(i);
            }
        }
    }
}