using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    // Student inherits Person class
    public class Student: Person
    {
        private int[] testScores;
        // student constructor is called at instantiation and first the base class's property is set along with child class's specific property
        public Student(string fN, string lN, int id, int[] testScores): base(fN, lN, id)
        {
            this.testScores = testScores;
        }

        public char Calculate()
        {
            char grade;
            int avgGrade = 0;
            int noOfScores = testScores.Length;
            Console.WriteLine(noOfScores);
            for (int score = 0; score <= testScores.Length -1; score++)
            {
                Console.WriteLine(testScores[score]);
                avgGrade += testScores[score];
            }
            avgGrade = avgGrade / testScores.Length; 
            Console.WriteLine("avgGrade: " + avgGrade); 

            if (avgGrade >= 90 && avgGrade <= 100)
            {
                grade = 'O';
            }
            else if(avgGrade >= 80 && avgGrade < 90)
            {
                grade = 'E';
            }
            else if(avgGrade >= 70 && avgGrade < 80)
            {
                grade = 'A';
            }
            else if(avgGrade >= 55 && avgGrade < 70)
            {
                grade = 'P';
            }
            else if(avgGrade >= 40 && avgGrade < 55)
            {
                grade = 'D';
            }
            else
            {
                grade = 'T';
            }

            Console.WriteLine("Name: " + lastName + ", " + firstName);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Grade: " + grade);
            return grade;

        }
    }
}
