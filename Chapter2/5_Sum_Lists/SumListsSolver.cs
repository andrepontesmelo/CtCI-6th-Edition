namespace SumLists
{
    public class SumListsSolver
    {
        public Node Sum(Node a, Node b)
        {
            Node result = Node.BuildSentinel();
            Node node = result;
            
            int carrier = 0;
            while (a.Next != null || b.Next != null || carrier != 0)
            {
                int aValue = a.Next != null ? a.Next.X : 0;
                int bValue = b.Next != null ? b.Next.X : 0;

                int sum = aValue + bValue + carrier;
                
                carrier = sum / 10;
                int remainder = sum % 10;

                node.Next = new Node(remainder);
                node = node.Next;

                if (a.Next != null)
                    a = a.Next;

                if (b.Next != null)
                    b = b.Next;
            }

            return result;
        }
    }
}