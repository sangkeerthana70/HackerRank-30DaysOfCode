using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            for(var i = 1; i <= 10; i++)
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
        }
    }
}
