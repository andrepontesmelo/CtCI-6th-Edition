using System;

namespace Palindrom
{
    public class Node
    {
        const char SENTINEL_CHAR = '\0';

        public char X;

        public Node Next;

        public Node(char x) 
        {
            this.X = x;
        }

        public Node() 
        {
            this.X = SENTINEL_CHAR;
        }

        public bool IsSentinel => X == SENTINEL_CHAR;

        internal static Node BuildSentinel()
        {
            return new Node();
        }

        public override string ToString() 
        {
            string thisStr = IsSentinel ? "" : string.Format("{0}", X);

            if (Next == null)
                return thisStr;

            return thisStr + Next.ToString();
        }

        public static Node FromString(string str)
        {
            char[] valuesStr = str.ToCharArray();
            Node head = Node.BuildSentinel();
            Node node = head;

            foreach (char value in valuesStr) 
            {
                node.Next = new Node(value);
                node = node.Next;
            }

            return head;
        }
    }
}