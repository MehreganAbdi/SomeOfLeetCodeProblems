using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode168
{
    public static class Ans
    {
        
        public static string ConvertToTitle(int columnNumber)
        {
            
            string alphabet = "#ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var ans = new List<char>(); 

                int j = 0;
            while (columnNumber > 0)
            {
                ans.Add(alphabet[columnNumber % 26 == 0 ? 26 : columnNumber % 26] );
                    columnNumber = (columnNumber-(columnNumber % 26 == 0 ? 26 : columnNumber % 26))/26;
                    j++;
                }



            alphabet = "";
            for(int i = ans.Count-1; i >= 0; i--)
            {
                alphabet = alphabet + ans[i];
            }



            return alphabet;
        }
    }
}
