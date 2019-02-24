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
            int[,] a = new int[6, 6] {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0 ,0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };
            /*
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
            int hourGlassSum = 0;
            int maxValue = int.MinValue;
            for(var i = 0; i < a.GetLength(0) - 2; i++)
            {
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



        }
    }
}
