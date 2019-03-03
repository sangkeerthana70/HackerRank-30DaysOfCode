using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            

            try
            {
                int convertToInt = int.Parse(S);
                Console.WriteLine(convertToInt);
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
