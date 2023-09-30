using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PhoneNumberToAlphabets
    {
        private readonly string[] mapping = new string[]{
            "",
        "",
        "abc",         "def",          "ghi",     "jkl",          "mno",         "pqrs",         "tuv",
        "wxyz"
   
        };
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;

            Backtrack(result, "", digits, 0);
            return result;
        }
        public void Backtrack(IList<string> result, string current, string digits, int index)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            int digit = digits[index] - '0';
            string letters = mapping[digit];

            for (int i = 0; i < letters.Length; i++)
            {
                Backtrack(result, current + letters[i], digits, index + 1);
            }
        }
    }
}
