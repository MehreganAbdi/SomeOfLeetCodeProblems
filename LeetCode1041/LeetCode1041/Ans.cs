using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1041
{
    public static class Ans
    {
        public static bool IsRobotBounded(string instructions)
        {
            int directionX = 0;
            int directionY = 1;

            int x = 0;
            int y = 0;


            foreach (var s in instructions)
            {
                if (s == 'G')
                {
                    x = x + directionX;
                    y = y + directionY;
                }
                else if (s == 'L')
                {
                    int z = directionX;
                    directionX = -directionY;
                    directionY = z;

                }
                else
                {
                    int z = directionX;
                    directionX = directionY;
                    directionY = -z;
                }
            }

            return ((x == 0 && y == 0) || (directionX != 0 || directionY != 1));
        }
    }
}
