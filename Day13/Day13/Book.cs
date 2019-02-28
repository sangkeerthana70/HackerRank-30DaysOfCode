using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public abstract class Book
    {

        public  String title;
        public String author;

        public Book(String t, String a) 
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
}
