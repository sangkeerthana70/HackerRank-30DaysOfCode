using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            // only child class is instantiated in abstract class
            MyBook myBook = new MyBook("harry potter", "J.K.Rowling", 14);
            myBook.display();
        }
    }
}
