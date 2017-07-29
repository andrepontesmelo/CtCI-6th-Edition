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
            int count = Count();

            Stack<char> stack = new Stack<char>();
            Node node = sentinel.Next;

            for (int x = 0; x < count / 2; x++)
            {
                stack.Push(node.X);
                node = node.Next;
            }

            if (count % 2 == 1)
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