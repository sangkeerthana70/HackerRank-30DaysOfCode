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
                Console.WriteLine("Age is not valid, setting age to 0.");
                
            }
            
        }
        // methods

        public void yearPasses()
        {
            age++;
            Console.WriteLine("Age: " + age);
            
        }

        public void amIOld()
        {
            Console.WriteLine("age passed to amIOld method: " + age);
            if (age < 13)
            {
                //Console.WriteLine("In less than 13");
                Console.WriteLine("You are young.");
            }
            else if((age >=13) && (age < 18))
            {
                //Console.WriteLine("In teenager");
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                //Console.WriteLine("In old age");
                Console.WriteLine("you are old.");
            }

        }
    }
}
