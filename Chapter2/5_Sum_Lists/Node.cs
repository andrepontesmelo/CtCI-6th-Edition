using System;

namespace SumLists
{
    public class Node
    {
        public int X;

        public Node Next;

        public Node(int x) 
        {
            this.X = x;
        }

        public Node() 
        {
            // Sentinel
            this.X = int.MinValue;
        }

        public bool IsSentinel => X == int.MinValue;

        internal static Node BuildSentinel()
        {
            return new Node();
        }

        public override string ToString() 
        {
            string thisStr = IsSentinel ? "" : string.Format("{0};", X);

            if (Next == null)
                return thisStr;

            return thisStr + Next.ToString();
        }

        public static Node FromString(string str)
        {
            string[] valuesStr = str.Split(';');
            Node head = Node.BuildSentinel();
            Node node = head;

            foreach (string strValue in valuesStr) 
            {
                if (!int.TryParse(strValue, out int value))
                    continue;

                node.Next = new Node(value);
                node = node.Next;
            }

            return head;
        }
    }
}