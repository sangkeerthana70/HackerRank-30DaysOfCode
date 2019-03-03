using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17
{
    public class Calculator
    {
        int n;
        int p;

       //public  Calculator()
       //{

       //}

        public int power(int n, int p)
        {
            // custom power method without using Math.Pow or recursion
            if (n < 0 || p < 0)
            {
                string Message = "n and p should be non-negative";
                throw new System.ArgumentException(Message);
                Console.WriteLine(Message);
            }
            // assign result to 1 to default the result of multiplying n ^ 0 to 1
            int result = 1;
            for (var i = 1; i <= p; i++)
            {
                Console.WriteLine("i: " + i);
                result *= n ;
                Console.WriteLine(result);
            }
            
            Console.WriteLine(result);
            return result;
        }
    }
}
