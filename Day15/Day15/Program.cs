using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class Solution
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method 
            // creates a new Node 
            Node myNode = new Node(data);
            // if the head Node which is the pointer pointing to the first node of the Linked list is null
            if (head == null)
            {
                return myNode;
            }

            // if head is not null assign the head which is the first element in linked list to variable currentNode
            Node currentNode = head;
            while (currentNode.next != null)
            {
                // traverse to the next element in the linked list
                currentNode = currentNode.next;
            }
            // currentNode from the while loop is checked to see if its next is null
            // if null assign myNode as currentNode's next elem by inserting it at the tail of the linked list
            currentNode.next = myNode;

            //Console.WriteLine("currentNode.next: " + currentNode.next.data);
            return head;
        }

        

        public static void display(Node head)
        {
            //Node start = head;
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }

    
}

