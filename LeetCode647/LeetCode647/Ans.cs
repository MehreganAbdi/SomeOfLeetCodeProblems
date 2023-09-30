using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode647
{
    public static class Ans
    {
        public static int CountSubstrings(string s)
        {
            int length = 1;
            int res = 0;
            int r = 0;
            int l = 0;
            for (int i = 0; i < s.Length; i++)
            {
                r = i; l = i;

                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    res++;
                    l--;
                    r++;
                }
                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    res++;
                    l--;
                    r++;
                }
            }
            return res;
        }
}
