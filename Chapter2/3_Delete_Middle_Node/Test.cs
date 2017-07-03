using System;
using Xunit;

namespace DeleteMiddleNode
{
    public class Test
    {
        [Fact]
        public void ShouldReadLinkedList()
        {
            // 1;2;3;
            Node head = new Node(1, new Node(2, new Node(3)));
            Assert.Equal("1;2;3;", head.ToString());
        }

        [Fact]
        public void ShouldDeleteMiddleNode()
        {
            // 1;2;3;
            Node second = new Node(2, new Node(3));
            Node head = new Node(1, second);

            new DeleteMiddle().DeleteMiddleNode(second);

            Assert.Equal("1;3;", head.ToString());
        }

        [Fact]
        public void ShouldDeleteFirstNode()
        {
            // 1;2;3;
            Node second = new Node(2, new Node(3));
            Node head = new Node(1, second);

            new DeleteMiddle().DeleteMiddleNode(head);

            Assert.Equal("2;3;", head.ToString());
        }
    }
}
