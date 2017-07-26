using System;

namespace Palindrom
{
    public abstract class PalindromSolver
    {
        protected Node sentinel;

        public Node Sentinel => sentinel;
        
        public abstract bool IsPalindrom();

        public PalindromSolver(string str)
        {
            sentinel  = Node.BuildSentinel();
            Node node = sentinel;
            
            foreach (char c in str)
            {
                node.Next = new Node(c);
                node = node.Next;
            }
        }

        public override string ToString()
        {
            return sentinel.ToString();
        }
    }
}