using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode62
{
    public static class Ans
    {
        public static int UniquePaths(int m, int n)
        {

            int[,] squares = new int[n, m];
            for (int i = n-1 ; i>=0 ; i--)
            {
                for (int j =m-1; j >=0; j--)
                {
                    if(i == n-1 || j == m - 1)
                    {
                        squares[i,j] = 1;
                    }
                    else
                    {
                        squares[i, j] = squares[i + 1, j] + squares[i, j + 1];
                    }
                }  
            }

            return squares[0,0];
        }

        public static int UniquePaths2(int m, int n)
        {

            // int Dia = m + n - 2;
            int Via = m - 1;

            double result = 1;

            //Dia - Via = m+n-2-m+1=n-1
            for (int i = 1; i <= Via; i++)
            {
                result = result * ((n-1) + i ) / i;
            }


            return (int)result;
        }
    }
}
