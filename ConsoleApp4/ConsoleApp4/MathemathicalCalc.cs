using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesFuncAction
{
    public class MathemathicalCalc
    {
        public delegate double TriangularFuncs(double x);
        
        


        public void ShowDifferential(TriangularFuncs function , double x , double dx)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for(int i = 0 ; i < x/dx ; i++)
            {
                stringBuilder.AppendLine($"{function.Method.Name}({Math.Round(i * dx,3)}) : {Math.Round(function(i * dx),3)}");
            }
            Console.WriteLine(stringBuilder);
        }


        Func<int, int, int> Multiplying = (int x, int y) => x * y;

        Action<int, int> Summation = (int x, int y) => x =x+y;



        public string Multiply(int x, int y )
        {
            return Multiplying(x,y).ToString();
           
        }

        public int Percentage(int x) => x / 100; 


    }
}
