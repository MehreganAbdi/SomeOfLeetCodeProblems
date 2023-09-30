using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode8_Atoi_
{
    public static class Ans
    {
        public static int MyAtoi(string s)
        {
            const int maxCmp = int.MaxValue / 10;
            var num = 0;
            var sign = 1;

            var idx = 0;
            while (idx < s.Length && s[idx] == ' ')
                idx++;

            if (idx < s.Length && (s[idx] == '+' || s[idx] == '-'))
                sign = s[idx++] == '-' ? -1 : 1;

            while (idx < s.Length && s[idx] > 47 && s[idx] < 58)
            {
                if (num > maxCmp || (num == maxCmp && (s[idx] - '0') > 7))
                    return sign == -1 ? int.MinValue : int.MaxValue;
                num = num * 10 + (s[idx++] - '0');
            }

            return num * sign;

        }
        public static int MyAtoi2(string s)
        {
            int i = 0;
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }
            var sign = 1;
            if (i < s.Length && (s[i] == '-' || s[i] == '+'))
            {
                sign = (s[i++] == '-' ? -1 : 1);
            }
            var num = 0;
            while (i < s.Length && s[i] > 47 && s[i] < 58)
            {
                if (num > (int.MaxValue / 10) || (num == int.MaxValue / 10 && s[i] - '0' > 7))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;

                }

                num = (10 * num) + (s[i++] - '0');
            }
            return num * sign;
        }
    }
}
