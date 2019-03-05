using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    // Calculator is the child class that inherits AdvancedArithmetic interface
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int divisorSum = 0;
            for(var i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                    divisorSum += i;
                    Console.WriteLine("divisorSum: " + divisorSum);
                }
            }
            return divisorSum;
        }
    }
}
