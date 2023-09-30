using System.Diagnostics.Metrics;

namespace LeetCode2483
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bestClosingTime("YYNY"));
        }
        public static int bestClosingTime(string customers)
        {
            int min_pen = 0;
            int min_Index = 0;
            
            foreach (char customer in customers) { if (customer == 'Y') min_pen++; }
            
            int cur_pen = min_pen;
            

            for(int i = 0; i<customers.Length; i++)
            {
                if (customers[i] == 'Y') cur_pen--;
                else cur_pen++;

                if (cur_pen < min_pen)
                {
                    min_pen = cur_pen;
                    min_Index = i;
                }
            }

            return min_Index;
        }
    }
}