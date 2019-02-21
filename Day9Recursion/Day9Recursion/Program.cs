using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);
        }

        private static int Factorial(int n)
        {
            //int factorial = 1;
            if( n == 0)
            {
                return 1;
            }
            
            
            return n * Factorial(n - 1); ;
        }
    }
}
