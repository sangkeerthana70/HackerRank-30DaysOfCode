using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            //string s = "Hacker";
            //string s2 = "Rank";

            int stringCount = Int32.Parse(Console.ReadLine());
            String currString;

            

            for(var i = 0; i < stringCount; i++)
            {
                currString = Console.ReadLine();
                //Console.WriteLine(currString);
                string oddChar = "";
                string evenChar = "";
                for (var j = 0; j < currString.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        evenChar += currString[j];
                    }
                    else
                    {
                        oddChar += currString[j];
                    }
                }
                Console.WriteLine(evenChar + " " + oddChar);
                
            }
            
        }
    }
}
