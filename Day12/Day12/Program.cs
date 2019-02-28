using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = new int[] { 100, 50, 70, 60, 80, 60 };

            // since student inherits person class it has inherited all the properties of the person class
            // including the properties specific to the student(child) class
            // and accessed here while instantiating 
            Student s = new Student("Ritika", "Charan", 3648762, testScores);

            s.Calculate();


        }
    }
}
