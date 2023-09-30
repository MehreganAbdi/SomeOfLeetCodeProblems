using System.Globalization;

namespace LeetCode125
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}

		public static bool ValidPalindrome(string s2)
		{
			int left = 0;
			int right = s2.Length - 1;

			while (left <= right)
			{
				if (!Char.IsLetterOrDigit(s2[left])) left++;
				else if (Char.IsLetterOrDigit(s2[right])) right--;
				else
				{
					if (s2[left] != s2[right]) return false;
					left++;
					right--;
				}
			}


			return true;
		}
	}
}