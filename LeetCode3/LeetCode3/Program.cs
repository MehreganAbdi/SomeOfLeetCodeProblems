namespace LeetCode3
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}

		public static int LongestSubstringWithoutDuplicates(string s)
		{
			if (s.Length == 0) return 0;

			var set = new HashSet<char>();
			int l = 0;
			int r = 0;
			
			int max = 0;
			while (r < s.Length)
			{
				if (set.Contains(s[r]))
				{
					set.Remove(s[l]);
					l++;
				}
				else
				{
					set.Add(s[r]);
					max = Math.Max(max, r - l + 1);
					r++;

				}
			}
			return max;

		}
	}
}