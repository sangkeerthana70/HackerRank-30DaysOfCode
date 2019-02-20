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
            int number = 12;
            



            //do
            //{

            //    remainder = number / 2;
            //    Console.WriteLine("rem: " + remainder);

            //    Console.WriteLine(number % 2);
            //    continue;
            //    i++;

            //}
            //while (!(number % 2 == 0));

            int remainder = number % 2;
            int quotient = number / 2;

            Console.WriteLine("quo : " + quotient);
            Console.WriteLine("rem : " + remainder);
            int i = 0;
            while (true)
            {
                
                // Continue dividing the quotient by 2 until you get a quotient of zero
                if (quotient != 0)
                {
                    Console.WriteLine("i: " + i);
                    Console.WriteLine("quotient: " + quotient);
                    
                    
                    quotient = quotient / 2;

                    remainder = quotient % 2;
                    Console.WriteLine(quotient % 2);
                    Console.WriteLine("quo1 : " + quotient);
                    Console.WriteLine("rem1: " + remainder);
                    
                }
                else
                {
                    break;
                }
                i++;

            }
                
               
             
            

                
            
            
        }
    }
}
