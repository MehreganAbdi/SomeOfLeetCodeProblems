namespace CodeLeet1963
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Ans.MinSwaps("]]][[["));
            int[] nums = { 2, 3, 4, 5, 6, 6 };
            int[] helper = new int[nums.Length];
            int k = 3;
            nums.Reverse();
            for(int i = 0; i< nums.Length; i++)
            {
                if(i <= k - 1 )
                {
                    helper[i] = nums[k - 1 - i];
                }
                else
                {
                    helper[i] = helper[nums.Length - i];
                }
               
            } nums = helper;
                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
        }
    }
}