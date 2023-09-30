namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = {1,3,4,5};
            Console.WriteLine(CoinChange(coins , 7));

        }


        public static int CoinChange(int[] coins , int target)
        {
            int[] domain = Enumerable.Repeat(target + 1, target + 1).ToArray();
            domain[0] = 0;
            foreach (int i in Enumerable.Range(1,target+1))
            {
                foreach(int j in coins)
                {
                    if (i-j>=0)
                    {
                        domain[i] = Math.Min(domain[i], 1 + domain[i - j]);
                    }
                }
            }



            return domain[target] != target ? domain[target] : -1;
        }
    }
}