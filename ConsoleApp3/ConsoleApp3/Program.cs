namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordDict = new List<string>();
            wordDict.Add("leet");
            wordDict.Add("code");

            Console.WriteLine(WordBreak("leetcode", wordDict));
        }

        /// <summary>
        /// LeetCode 139
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;
            bool[] ans = new bool[n + 1];
            ans[0] = true;
            int max_len = 0;


            foreach (var word in wordDict)
            {
                max_len = Math.Max(max_len, word.Length);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = i - 1; j >= Math.Max(i - max_len - 1, 0); j--)
                {
                    if (ans[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        ans[i] = true;
                        break;
                    }
                }
            }

            return ans[n];
        }

    }
}