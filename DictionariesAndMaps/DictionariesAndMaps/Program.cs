using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            /*
            phoneBook.Add("sam", 99912222);
            phoneBook.Add("harry", 12299933);
            phoneBook.Add("tom", 11122222);
            
            foreach (var pair in phoneBook)
            {
                //Console.WriteLine("key = {0} value = {1} ", pair.Key, pair.Value);
                Console.WriteLine("pair.key: " + pair.Key);
                if (phoneBook.ContainsKey(pair.Key))
                {
                    Console.WriteLine( pair.Key + "=" + pair.Value);

                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }
            */

            var n = int.Parse(Console.ReadLine());


            // must continue reading lines until there is no more input.
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                Console.WriteLine(input.GetType());
                var name = input[0];
                Console.WriteLine(name.GetType());
                var phoneNum = int.Parse(input[1]);
                Console.WriteLine(phoneNum.GetType());
                phoneBook.Add(name, phoneNum);
            }

            foreach (var pair in phoneBook)
            {
                if (phoneBook.ContainsKey(pair.Key))
                {
                    Console.WriteLine(pair.Key + "=" + pair.Value);

                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }






        }
    }
}
