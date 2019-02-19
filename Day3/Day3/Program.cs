using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            if(n % 2 == 0)
            {
                if(n > 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                if(n > 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
               
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
