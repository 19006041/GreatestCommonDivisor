using System;

namespace GreatestCommonDivisor
{
    class Program
    {


        public static int Hcf(int n1, int n2)
        {
            if (n2 != 0)
                return Hcf(n2, n1 % n2);
            else
                return n1;
        }

        static void Main(string[] args)
        {
            //Using recursion to find the greatest common divisor of 2 numbers.
            string val;
            Console.Write("Enter First Integer: ");
            val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            Console.Write("Enter Second Integer: ");
            val = Console.ReadLine();
            int b = Convert.ToInt32(val);

            int hcf = Hcf(a, b);
            Console.Write("Greatest Common Divisor (G.C.D) of {0} and {1} is {2}.", a, b, hcf);
            Console.ReadKey();
        }
    }
}
