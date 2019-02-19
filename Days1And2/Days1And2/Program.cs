using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days1And2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Day-0
            // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
            Console.WriteLine(Console.ReadLine());
            */

            // Day-1
            int i = 12;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.

            int i2;
            double d2;
            string s2;
            // Read and save an integer, double, and String to your variables.
            i2 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:.0}", d + d2);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);

        }
    }
}
