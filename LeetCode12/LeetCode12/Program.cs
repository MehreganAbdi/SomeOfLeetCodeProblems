using System.Globalization;

namespace LeetCode12
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static string IntegerToRoman(int x)
        {
            int[] nums = { 1,4, 5,9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] equivalent = { "I","IV", "V","IX" ,"X", "XL","L", "XC", "C", "CD","D", "CM","M" };
            var res = "";
            for(int i=nums.Length-1; i>=0;i--)
            {
                if (x / nums[i] > 0)
                {
                    int count = x / nums[i];

                    for (int j = 0; j < count; j++)
                    {
                        res = res + equivalent[i];
                    } 
                    
                    x = x % nums[i];

                }
            }



            return res;
        }
    }
}