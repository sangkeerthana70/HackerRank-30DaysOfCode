using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 951;
            List<int> result = new List<int> ();
            int quotient = number;
            int remainder = 0;
            while (quotient != 0)
            {               
               // Continue dividing the quotient by 2 until you get a quotient of zero
                remainder = quotient % 2;
                Console.WriteLine("remainder: " + remainder);
                quotient = quotient / 2;
                result.Add(remainder);                                       
            }
            Console.WriteLine("result: " + result);
            string binary = string.Empty;
            for(var i = 0; i < result.Count; i++)
            {
                // reverses the elements in result array
                binary += result[result.Count - 1 - i];
                Console.WriteLine("binary: " + binary);
            }


            Console.WriteLine(CheckConsecutiveOnes(binary));
            /*
            int value = 12;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("b: " + binary);
            */
        }

        private static int CheckConsecutiveOnes(string binary)
        {
            //binary = "11101111";
            //Console.WriteLine(binary);
            int count = 0;
            int maxCount = 0;

            for(var i = 0; i < binary.Length; i++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("binary[i]: " + binary[i]);
                Console.WriteLine(binary[i].GetType());
                Console.WriteLine(binary[i] == '1');
                if(binary[i] == '1')
                {
                    count += 1;
                }
                // if(binary[i] == '0'
                else
                {
                    count = 0;
                }
                
                if (count > maxCount)
                {
                    maxCount = count;
                }
                //Console.WriteLine("count: " + count);
                //Console.WriteLine("maxCount: " + maxCount);
            }
            
            //Console.WriteLine("count: " + maxCount);
            return maxCount;
        }
    }
}
