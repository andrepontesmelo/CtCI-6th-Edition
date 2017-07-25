using System;

namespace Palindrom
{
    public class PalindromSolverReverse : PalindromSolver
    {
        public override bool IsPalindrom(Node a)
        {
            Node r = Reverse(a);

            while (a != null)
            {
                if (a.X != r.X)
                    return false;
                
                a = a.Next;
                r = r.Next;
            }

            return true;
        }

        public Node Reverse(Node a)
        {
            // Skip sentinel
            a = a.Next;

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
    }
}