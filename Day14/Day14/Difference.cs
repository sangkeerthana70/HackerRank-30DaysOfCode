using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    class Difference
    {
        private int[] elements;
        // this property has scope of entire class, so the maximumDifference returned from method will be assigned to this property. 
        public int maximumDifference;
        
        // Add your code here
        public Difference(int [] e)
        {
            this.elements = e;
            

        }
        // method to find the max difference
        public void computeDifference()
        {
            int difference = 0;
            maximumDifference = int.MinValue;
            // access the array elements in int [] elements which has scope of entire class
            for (var i = 0; i < elements.Length - 1; i++)
            {
                
                //Console.WriteLine("i " + i);
                //Console.WriteLine("elements[i] " + elements[i]);
                for(var j = i+1; j < elements.Length; j++)
                {
                    //Console.WriteLine("j: " + j);
                    //Console.WriteLine("elements[j] " + elements[j]);
                    difference = Math.Abs(elements[i] - elements[j]);
                    //difference = Math.Abs(difference);
                    //Console.WriteLine("difference: " + difference);                   
                    if (difference > maximumDifference)
                    {
                        maximumDifference = difference;                       
                    }
                    //Console.WriteLine("maxDiff: " + maximumDifference);
                } 
            }
            //Console.WriteLine("maximumDifference: " + maximumDifference);
        }

    }
}
