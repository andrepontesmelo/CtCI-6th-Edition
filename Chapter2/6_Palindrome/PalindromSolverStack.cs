using System;
using System.Collections.Generic;

namespace Palindrom
{
    public class PalindromSolverStack : PalindromSolver
    {
        public PalindromSolverStack(string str) : base(str)
        {
        }

        public override bool IsPalindrom()
        {
            Stack<char> stack = new Stack<char>();
            Node node = sentinel.Next;
            Node runner = node;
            bool isOdd = false;

            while (runner != null)
            {
                runner = runner.Next;

                if (runner != null)
                {
                    stack.Push(node.X);
                    node = node.Next;

                    runner = runner.Next;
                }
                else
                    isOdd = true;
            }

            if (isOdd)
                node = node.Next;

            while (node != null)
            {
                if (node.X != stack.Pop())
                    return false;

                node = node.Next;
            }
            
            return stack.Count == 0;
        }

        public int Count()
        {
            Node node = sentinel.Next;
            int count = 0;

            while (node != null)
            {
                node = node.Next;
                count++;
            }

            return count;
        }

        public static PalindromSolverStack FromString(string str)
        {
            return new PalindromSolverStack(str);
        }

    }
}
