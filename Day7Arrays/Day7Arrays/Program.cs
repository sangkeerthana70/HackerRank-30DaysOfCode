using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] resultArr = ReverseArray(arr);
            
        }

        private static int [] ReverseArray(int[] arr)
        {
            // pseudocode
            // start looping through the given integer array 
            // set i initial value as the length of the array -1 
            // i > 0
            // i--
            // the last element(-1) in array 1 will be assigned to first element in the reversed array
            // eg: [1 2 3 4]
            // reversed arrays's start index will be old array's length - 1 EG: reversedArr[len - i] = arr[i];
            // reversed element will be [4 3 2 1]

            //Console.WriteLine(arr.Length);
            int len = arr.Length - 1;
            int[] reversedArr = new int[arr.Length];
            
            for(var i = len; i >= 0; i--)
            {
                Console.WriteLine("i = " + i);
                Console.WriteLine("arr1[i] = " + arr[i]);
                Console.WriteLine();
                reversedArr[len - i] = arr[i];
            }
            Console.WriteLine("Copy reversed element into reversedArray");
            Console.WriteLine(String.Join(" ", reversedArr));
            return reversedArr;                     
        }
    }
}
