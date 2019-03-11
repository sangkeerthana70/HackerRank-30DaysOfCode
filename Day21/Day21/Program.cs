using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            */

            //-----------------------
            //instantiate generic with Integer  
            Generics<int> gen = new Generics<int>();

            //adding integer values into collection  
            gen.Add(1);
            gen.Add(2);
            gen.Add(3);
            gen.Add(4);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(gen[i]);   //No unboxing  
            }
            Console.ReadKey();

            //PrintArray<Int32>(intArray);
            
            //PrintArray<String>(stringArray);
            
        }

        public class Generics<T> where T : IComparable
        {
            T[] obj = new T[5];
            int count = 0;
            //indexer for foreach statement iteration  
            public T this[int index]
            {
                get { return obj[index]; }
                set { obj[index] = value; }
            }

            public void Add(T item)
            {
                if(count + 1 < 6)
                {
                    obj[count] = item;
                }
                count++;
            }



            /**
            *    Name: PrintArray
            *    Print each element of the generic array on a new line. Do not return anything.
            *    @param A generic array
            **/
            // Write your code here*/
        }

        public static  void PrintArray<T>(T value)
        {
            int[] array = new int[] { };
            //for(var i = 0; i < count; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
        }

    }


}

       

    

