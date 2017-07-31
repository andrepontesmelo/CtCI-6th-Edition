using System;
using System.Collections.Generic;

namespace Palindrom
{
    public class PalindromSolverRecursive : PalindromSolver
    {
        public PalindromSolverRecursive(string str) : base(str)
        {
        }

        public static PalindromSolverRecursive FromString(string str)
        {
            return new PalindromSolverRecursive(str);
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

        public override bool IsPalindrom()
        {
            Result result = IsPalindromRecursive(Count(), sentinel.Next);
            
            return result.IsPalindrom;
        }

        private Result IsPalindromRecursive(int countdown, Node node)
        {
            Result result;
            if (countdown == 2)
            {
                //  _
                // ABBA
                result = new Result();
                result.IsPalindrom = node.X == node.Next.X;
                result.Node = node.Next?.Next;
 
                return result;
            } else if (countdown == 1)
            {
                result = new Result();
                result.IsPalindrom = true;
                result.Node = node.Next;

                return result;
            }
            
            result = IsPalindromRecursive(countdown - 2, node.Next);

            result.IsPalindrom = result.IsPalindrom && (node.X == result.Node.X);
            result.Node = result.Node.Next;

            return result;
        }   

        private class Result 
        {
            public Node Node;
            public bool IsPalindrom;
        }
    }
}