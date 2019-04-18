using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            string result = FindIsPrime(n);
            Console.WriteLine("result: " + result);
        }
        public static string FindIsPrime(int n)
        {
           
            for(int i = 2; i < n; i++)
            {
                Console.WriteLine("i : " + i);
                if(n % i == 0)
                {
                    Console.WriteLine("n%i: " + n%i);
                    Console.WriteLine("Not prime");
                    return "Not prime";
                }
                

            }
            
            return "Prime";
        }
    }
}
