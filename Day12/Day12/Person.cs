using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{  
    public class Person
    {
        public string firstName;
        public string lastName;
        public int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
}

