using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // two dimensional array
            int[,] a = new int[6, 6] {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0 ,0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };
            /*
             * accessing rows and columns in a 2D-Array
            //Console.WriteLine(a.GetLength(0));
            for(var i = 0; i < a.GetLength(0); i++)
            {
                for(var j = 0; j < a.GetLength(1); j++)
                {
                    //Console.WriteLine(a[i,0]);
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            */

            /* Old solution
            int hourGlassSum = 0;
            int maxValue = int.MinValue;
            // Outer loop to get upto 4 rows 
            for (var i = 0; i < a.GetLength(0) - 2; i++)
            {
                // Inner loop to get upto 4 columns 
                for (var j = 0; j < a.GetLength(1) - 2; j++)
                {
                    Console.WriteLine("({0},{1})",i,j);
                    hourGlassSum = a[i, j] + a[i, j + 1] + a[i, j + 2] ;
                    hourGlassSum += a[i + 1, j + 1];
                    hourGlassSum += a[i + 2, j] + a[i + 2, j + 1] + a[i + 2, j + 2];
                    Console.WriteLine(hourGlassSum);
                    if(hourGlassSum > maxValue)
                    {
                        maxValue = hourGlassSum;
                    }
                }

            }
            Console.WriteLine("maxSum: " + maxValue);
            */
            // defines a array of arrays
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int hourGlassSum = 0;
            int maxValue = int.MinValue;
            for (var i = 0; i < arr.Length - 2; i++)
            {
                // Inner loop to get upto 4 columns 
                for (var j = 0; j < arr[i].Length - 2; j++)
                {
                    //Console.WriteLine("({0},{1})",i,j);
                    hourGlassSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    hourGlassSum += arr[i + 1][j + 1];
                    hourGlassSum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    //Console.WriteLine(hourGlassSum);
                    if (hourGlassSum > maxValue)
                    {
                        maxValue = hourGlassSum;
                    }
                }

            }
            Console.WriteLine(maxValue);

        }


    }
    
}
