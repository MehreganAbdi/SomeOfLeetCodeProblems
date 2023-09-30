namespace DelegatesFuncAction
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var Sample1 = new MathemathicalCalc();
            Console.WriteLine(Sample1.Multiply(3,6));


            //Sample1.ShowDifferential(Math.Sin, Math.PI/2, 0.1);
            FunctionsType1 func1 = Kossher;
            func1 += Kossher2;
            func1 += Kossher3;

            Console.WriteLine(func1(2));//All methode will be executed but only las method added to func1 will return a value

        }

        public  delegate double FunctionsType1(double x);

        public static double Kossher(double a)
        {
            Console.WriteLine("Kossher1 Executed");
            return a*a;
        }
        public static double Kossher2(double a)
        {
            Console.WriteLine("Kossher2 Executed");
            return a*a*a;
        }
        public static double Kossher3(double a)
        {
            Console.WriteLine("Kossher3 Executed");
            return a*a*a*a;
        }
    }
}
