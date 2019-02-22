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
            List<int> result = new List<int> ();
            int quotient = number;
            int remainder = 0;
            while (quotient != 0)
            {               
                // Continue dividing the quotient by 2 until you get a quotient of zero
 
                remainder = quotient % 2;
                quotient = quotient / 2;
                result.Add(remainder);                                       
            }
            string binary = string.Empty;
            for(var i = 0; i < result.Count; i++)
            {
                binary += result[result.Count - 1 - i]; 
            }
            Console.WriteLine(binary);
            

            /*
            int value = 12;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("b: " + binary);
            */
        }









    }
    
}
