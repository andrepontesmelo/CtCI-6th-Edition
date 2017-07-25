using System;

namespace Palindrom
{
    public abstract class PalindromSolver
    {
        public abstract bool IsPalindrom(Node a);

        public static Node FromString(string str)
        {
            Node sentinel = Node.BuildSentinel();
            Node node = sentinel;
            
            foreach (char c in str)
            {
                node.Next = new Node(c);
                node = node.Next;
            }

            return sentinel;
        }
    }
}