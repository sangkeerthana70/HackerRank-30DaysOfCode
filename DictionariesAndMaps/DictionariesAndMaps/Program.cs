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
            string query = string.Empty;
            while ((query = Console.ReadLine()) != null)
            {
                
                if (phoneBook.ContainsKey(query))
                {
                    Console.WriteLine(query + "=" + phoneBook[query]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
           
           






        }
    }
}
