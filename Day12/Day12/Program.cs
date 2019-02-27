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
            Student s = new Student(testScores);
            // since student inherits person class it has inherited all the properties of the person class
            // and accessed here while instantiating
            s.firstName = "Ritika";
            s.lastName = "Charan";
            s.id = 3648762;

            s.Calculate();


        }
    }
}
