using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18
{
    class Solution
    {
        //Write your code here
        Queue<char> myQueue = new Queue<char>();
        Stack<char> myStack = new Stack<char>();

        public void pushCharacter(char c)
        {

            myStack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            myQueue.Enqueue(c);
        }

        public char popCharacter()
        {
            // return the character that was popped
            return myStack.Pop();
        }

        public char dequeueCharacter()
        {
            // return the character that was dequeued
            return myQueue.Dequeue();

        }


        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                //char popStack = obj.popCharacter();
                //char popQu = obj.dequeueCharacter();
                //Console.WriteLine("obj.popCharacter: " + popStack);
                //Console.WriteLine("obj.dequeueCharacter: " + popQu);
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
    
}
