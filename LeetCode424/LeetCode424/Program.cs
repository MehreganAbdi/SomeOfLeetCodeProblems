namespace LeetCode424
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CharacterReplacement("AABABBA", 2));
		}

		public static int CharacterReplacement(string s, int k)
		{
			int l = 0, res = 0, mostFrequent = 0;
			int[] charAsciiCounts = new int[26];

			for (int r = 0; r < s.Length; r++)
			{
				charAsciiCounts[s[r] - 'A']++;

				mostFrequent = Math.Max(mostFrequent, charAsciiCounts[s[r] - 'A']);

				int charsToChange = r - l + 1 - mostFrequent;

				if (charsToChange > k)
				{
					charAsciiCounts[s[l] - 'A']--;
					l++;
				}
				res = Math.Max(res, r - l + 1);
			}


			return res;
		}
	}
}