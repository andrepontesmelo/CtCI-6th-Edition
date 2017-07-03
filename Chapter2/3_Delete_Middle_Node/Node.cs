namespace DeleteMiddleNode
{
    public class Node
    {
            public int X;

            public Node Next;

            public Node(int x) 
            {
                this.X = x;
            }

            public Node(int x, Node next) : this(x)
            {
                this.Next = next;
            }

            public override string ToString() 
            {
                return string.Format("{0};", X) + (Next != null ? Next.ToString() : "");
            }
    }
}