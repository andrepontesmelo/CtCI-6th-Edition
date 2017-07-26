using System;

namespace Palindrom
{
    public class PalindromSolverReverse : PalindromSolver
    {
        public override bool IsPalindrom()
        {
            return Matches(Reverse());
        }

        public bool Matches(Node b)
        {
            Node a = sentinel;

            while (a != null && b != null)
            {
                if (a.X != b.X)
                    return false;
                
                a = a.Next;
                b = b.Next;
            }

            return a == b;
        }

        public bool Matches(PalindromSolverReverse other)
        {
            return Matches(other.Sentinel);
        }

        public Node Reverse()
        {
            Node a = sentinel.Next;

            Node node = new Node();

            while (a != null)
            {
                node.X = a.X;
                
                Node tmp = node;
                node = new Node();
                node.Next = tmp;

                a = a.Next;
            }

            return node;
        }

        public static PalindromSolverReverse FromString(string str)
        {
            return new PalindromSolverReverse(str);
        }

        public PalindromSolverReverse(string str) : base(str)
        {
        }
    }
}