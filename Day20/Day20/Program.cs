﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // Write Your Code Here
            bubbleSort(a, n);
            
        }

       

        public static void bubbleSort(int[] a, int n)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Loop i: " + i);

                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("Loop J: " + j);
                    Console.WriteLine("a[j]: " + a[j]);
                    Console.WriteLine("a[j + 1]: " + a[j + 1]);
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        Console.WriteLine("Before swap: " + a[j] + " " + a[j + 1]);
                        //swap(a[j], a[j + 1]);
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        Console.WriteLine("After swap: " + a[j] + " " +  a[j + 1]);
                        numberOfSwaps++;
                        Console.WriteLine("Number of swaps: " + numberOfSwaps);

                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }

            }
            Console.WriteLine("Sorted array");
            foreach (var snum in a)
            {
                Console.WriteLine("Each Elem: " + snum);
            }

            Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length - 1]);
        }

        
    }
}
