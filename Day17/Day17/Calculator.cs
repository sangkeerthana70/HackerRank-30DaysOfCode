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
            if (n < 0 || p < 0)
            {
                string Message = "n and p should be non-negative";
                throw new System.ArgumentException(Message);
                Console.WriteLine(Message);
            }
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
