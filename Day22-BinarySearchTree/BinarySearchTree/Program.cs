using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
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
            int height = getHeight(root);
            Console.WriteLine(height);

        }

        static int getHeight(Node root)
        {
            //Write your code here
            /*
            if (root == null) return -1;
            return (1 + Math.Max(getHeight(root.left), getHeight(root.right)));
            */

            int height = 0;

            if (root == null)
                return -1;

            int left = getHeight(root.left);
           
            int right = getHeight(root.right);

            if (left > right)
            {
                height = 1 + left;
                Console.WriteLine("In If: " + height);
            }
            else
            {
                height = 1 + right;
                Console.WriteLine("In else:  " + height);
            }



            //return Math.Max(left, right);
            return height;

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
    }

}
