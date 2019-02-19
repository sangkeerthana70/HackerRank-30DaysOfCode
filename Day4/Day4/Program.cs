using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the Person class
            Person person = new Person(0);
            // set the new instance of person's age 
            person.age = 10;
            // call the method inside Person class
            person.yearPasses();
            person.amIOld();

            Person a = new Person(-1);
            a.yearPasses();
            
            Console.WriteLine("now a.age is: " + a.age);
            a.amIOld();
            

            


        }
    }
}
