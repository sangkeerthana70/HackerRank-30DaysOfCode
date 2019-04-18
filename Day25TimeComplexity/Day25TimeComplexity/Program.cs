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
            //Console.WriteLine("t: " + T);
            for(int i = 0; i < T; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("n: " + n);
                string result = FindIsPrime(n);
                Console.WriteLine("result: " + result);
            }

        }
        public static string FindIsPrime(int n)
        {
           
            for(int i = 2; i < n; i++)
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
