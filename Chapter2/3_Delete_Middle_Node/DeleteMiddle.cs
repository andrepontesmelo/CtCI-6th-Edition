namespace DeleteMiddleNode
{
    public class DeleteMiddle
    {
        public void DeleteMiddleNode(Node node) 
        {
            Node last = node;

            while (node.Next != null)
            {
                node.X = node.Next.X;
                last = node;
                node = node.Next;
            }

            last.Next = null;
        }
    }
}