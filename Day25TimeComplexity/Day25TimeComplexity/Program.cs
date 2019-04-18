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
           
            int T = Convert.ToInt32(Console.ReadLine());
           
            for(int i = 0; i < T; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());              
                string result = FindIsPrime(n);
                Console.WriteLine(result);
            }

        }
        public static string FindIsPrime(int n)
        {
            if (n == 1)
                return "Not prime";
           
            for(int i = 2; i*i <= n; i++)
            { 
                if(n % i == 0)
                {
                    
                    return "Not prime";
                }
            }
            
            return "Prime";
        }
    }
}
