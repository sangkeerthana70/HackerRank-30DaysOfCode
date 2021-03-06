﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            Console.WriteLine("res: " + head.data);
            display(head);
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            Node current = head;
            
            while(current != null && current.next != null)
            {
                Node relink;
                if(current.data == current.next.data)
                {
                    relink = current.next.next;
                    current.next = relink;
                }
                else
                {
                    current = current.next;
                }
                

            }
            return head;

        }
        

    }

}

   

