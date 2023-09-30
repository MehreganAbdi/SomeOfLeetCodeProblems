using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLeet1963
{
    public static  class Ans
    {
        public static int MinSwaps(string s)
        {
           
            int ans = 0;
            for (int i = 0, count = 0; i < s.Length; ++i)
                if ((count += (s[i] == '[' ? 1 : -1)) < 0)
                {
                    count += 2;
                    ans += 1;
                }
            return ans;
        }
    }
}
