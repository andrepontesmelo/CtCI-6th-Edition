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

        public int Count(Node a)
        {
            int count = 0;

            while (a.Next != null)
            {
                count++;
                a = a.Next;
            }

            return count;
        }

        public void PadZeroLeft(Node a, int count)
        {
            if (count == 0)
                return;

            Node first = a.Next;
            a.Next = new Node(0);
            a.Next.Next = first;

            PadZeroLeft(a, count - 1);
        }

        public Node SumFollowUp(Node a, Node b)
        {
            int countA = Count(a);
            int countB = Count(b);

            if (countA > countB)
                PadZeroLeft(b, countA - countB);
            else
                PadZeroLeft(a, countB - countA);

            SumResult sumResult = SumFollowUpRecursive(a.Next, b.Next);

            Node result = Node.BuildSentinel();
            result.Next = sumResult.Node;

            if (sumResult.Carrier > 0) 
            {
                Node first = result.Next;
                result.Next = new Node(sumResult.Carrier);
                result.Next.Next = first;
            }

            return result;
        }

        private SumResult SumFollowUpRecursive(Node a, Node b)
        {
            SumResult resultRight = null;

            if (a.Next != null) 
                resultRight = SumFollowUpRecursive(a.Next, b.Next);

            SumResult result = new SumResult();

            int val = a.X + b.X;
            
            if (resultRight != null) 
                val += resultRight.Carrier;

            result.Carrier = val / 10;
            result.Node = new Node(val % 10);

            if (resultRight != null)
                result.Node.Next = resultRight.Node;

            return result;
        }
    }
}