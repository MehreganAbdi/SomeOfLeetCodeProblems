

namespace LeetCode49
{
    public static class Ans
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            
            var myDic = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (myDic.ContainsKey(SortString(strs[i])))
                {
                    myDic[SortString(strs[i])].Add(strs[i]);
                }
                else
                {
                    myDic.Add(SortString(strs[i]), new List<string>() { strs[i] });
                }
            }
            return myDic.Values.ToList();
        }
        private static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
