using LeetCode239;

namespace LeetCode239
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
 
            var x1 = LeetCode239.LC239.MaxSlidingWindow(nums, 3);
            Console.WriteLine(x1[0]+" " + x1[1]+" " + x1[2]);

        }
    }



    
}