using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    class MyBook : Book
    {
        int price;
        // MyBook constructor calls the super class's constructor
        public MyBook(string t, string a, int price) : base(t,a)
        {           
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);

        }
    }
}
