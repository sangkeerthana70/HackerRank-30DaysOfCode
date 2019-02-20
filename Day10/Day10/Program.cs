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
            int remainder = 0;
            int quotient = 0;
            
            

            //do
            //{

            //    remainder = number / 2;
            //    Console.WriteLine("rem: " + remainder);

            //    Console.WriteLine(number % 2);
            //    continue;
            //    i++;

            //}
            //while (!(number % 2 == 0));

            remainder = number % 2;
            quotient = number / 2;
            Console.WriteLine("rem : " + remainder);
            Console.WriteLine("quo : " + quotient);

            while (true)
            {
                
                if (quotient != 0)
                {
                    
                    quotient = quotient / 2;

                    remainder = number % 2;
                    Console.WriteLine("quo1 : " + quotient);
                    Console.WriteLine("rem1: " + remainder);
                    
                }
                else
                {
                    break;
                } 

            }
                
               
             
            

                
            
            
        }
    }
}
