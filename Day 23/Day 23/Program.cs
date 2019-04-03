using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23
{
    class Program
    {
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        //Write your code here
        public static void levelOrder(Node root)
        {

            //use Queue data structure to traverse the binary tree and print the nodes
            Queue<Node> myQ = new Queue<Node>();
            if (root == null)
            {
                return;
            }
            else
            {
                myQ.Enqueue(root);
            }

            // while queue is not empty and has at least one node in it
            while (myQ.Count > 0)
            {
                // peek at the node in the front of the queue to print its value
                Node nodeInFrontOfQueue = myQ.Peek();               
                Console.Write(nodeInFrontOfQueue.data + " ");
                
                // enqueue its children
                if (nodeInFrontOfQueue.left != null)
                {
                    myQ.Enqueue(nodeInFrontOfQueue.left);
                }
                if (nodeInFrontOfQueue.right != null)
                {
                    myQ.Enqueue(nodeInFrontOfQueue.right);
                }
                // finally dequeue the first node in the queue
                myQ.Dequeue();
                //Console.WriteLine("No of elements in the queue: {0}", myQ.Count);

            }
        }
    }
}
