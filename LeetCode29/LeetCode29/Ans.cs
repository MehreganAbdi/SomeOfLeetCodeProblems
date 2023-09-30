using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode29
{
    public static class Ans
    {
        public static int Divide(int dividend, int divisor)
        {
            int count = 0;
            bool x = false;
            if(divisor<0 || dividend < 0)
            {
                x= true;
                dividend = Math.Abs(dividend);
                divisor = Math.Abs(divisor);
            }

            while(dividend > divisor)
            {
                dividend -= divisor;
                count++;

            }
            if (x == true) { count = -count; }
            
            return  count;
        }
    }
}
