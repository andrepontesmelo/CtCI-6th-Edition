namespace Partition
{
    public class PartitionSolver
    {
        public Node Partition(Node inputHead, int x) 
        {
            Node lower = Node.BuildSentinel();
            Node higher = Node.BuildSentinel();
            Node lowerHead = lower;
            Node higherHead = higher;

            Node node = inputHead;

            while (node != null) 
            {
                bool useLowerList = node.X < x;

                if (useLowerList)
                {
                    lower.Next = new Node(node.X);
                    lower = lower.Next;
                } else
                {
                    higher.Next = new Node(node.X);
                    higher = higher.Next;
                }   
            
                node = node.Next;
            }

            lower.Next = higherHead.Next;

            return lowerHead;
        }
    }
}