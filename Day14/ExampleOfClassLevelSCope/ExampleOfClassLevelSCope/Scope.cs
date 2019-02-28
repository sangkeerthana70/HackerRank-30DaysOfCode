using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfClassLevelSCope
{
    public class Scope
    {
        bool b = true; // b1 has scope of entire class
        int x = 88; // x1 has scope of entire class

        public Scope()
        {
            double d = 9.0;
            example(d);
            classVariable();
        }
        
        private void example(double x)
        {
            // parameter x2 has scope of this method
            Console.WriteLine("----- example(double x):\n" + "Initial value of Local Variable `x`: " + x + "\n");
            x = 4.4; // reassign value of local variable x2
            Console.WriteLine("New value of Local Variable `x`: " + x + "\n");


            for (int b = 0; b < 4; b++)
            { // b2 has scope of this loop
                int i = b + 4; // begin scope of int i
                Console.WriteLine("For Loop 1 in example(double x):\n"
                    + "Local Variable `b` (local to loop): " + b + "\n"
                    + "Local Variable `i` (local to loop): " + i + "\n"
                    + "Local Variable `x` (method parameter): " + x + "\n");
            } // end the scope of int b2; end scope of int i

            for (int b = 0; b < 4; b++)
            {
                x = b;
                Console.WriteLine("For Loop 2 in example(double x):\n"
                    + "Local Variable `b` (local to loop): " + b + "\n"
                    + "Local Variable `x` (method parameter): " + x + "\n");
            } // end of the scope of this version of int b

            Console.WriteLine("Local Variable `x` after Loop 2: " + x + "\n");

        }// end scope of double x2

        private void classVariable()
        {
            Console.WriteLine("----- classVariable():\n"
                + "Instance Variable `b`: " + b + "\n"
                + "Instance Variable `x`: " + x);
        }


        
    }
}
