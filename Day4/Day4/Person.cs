using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Person
    {
        // properties
        public int age;
        // constructor 
        public Person(int initialAge)
        {
            if(!(initialAge < 0))
            {
                this.age = initialAge;
            }
            else
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0");
            }
            
        }
        // methods

        public void yearPasses(int age)
        {
            age++;
            Console.WriteLine("Age: " + age);
            
        }

        public void amIOld(int age)
        {
            if(age < 13)
            {
                Console.WriteLine("You are young");
            }
            if(age >=13 && age <= 18)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("you are old");
            }

        }
    }
}
