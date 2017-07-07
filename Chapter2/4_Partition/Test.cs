using System;
using Xunit;

namespace Partition
{
    public class Test
    {
        [Fact]
        public void ShouldParseLinkedList()
        {
            // 1;2;3;
            Node head = Node.FromString("1;2;3;");
            Assert.Equal("1;2;3;", head.ToString());
        }

        [Fact]
        public void ShouldPartitionString()
        {
            Node head = Node.FromString("1;2;8;9;3;5;5;3");
            
            Node partitioned = new PartitionSolver().Partition(head, 5);
            Assert.Equal("1;2;3;3;8;9;5;5;", partitioned.ToString());
        }

        [Fact]
        public void ShouldPartitionEmptyStringHigherX()
        {
            Node head = new Node(5);
            
            Node partitioned = new PartitionSolver().Partition(head, 10);
            Assert.Equal("5;", partitioned.ToString());
        }

        [Fact]
        public void ShouldPartitionEmptyStringLowerX()
        {
            Node head = new Node(5);
            
            Node partitioned = new PartitionSolver().Partition(head, 1);
            Assert.Equal("5;", partitioned.ToString());
        }


        [Fact]
        public void ShouldRetornOnlyLowerValues()
        {
            Node head = Node.FromString("1;2;3");
            
            Node partitioned = new PartitionSolver().Partition(head, 10);
            Assert.Equal("1;2;3;", partitioned.ToString());
        }

        [Fact]
        public void ShouldRetornOnlyHigherValues()
        {
            Node head = Node.FromString("12;13;14");
            
            Node partitioned = new PartitionSolver().Partition(head, 10);
            Assert.Equal("12;13;14;", partitioned.ToString());
        }

        [Fact]
        public void ShouldPartitionOneElementEachSide()
        {
            Node head = Node.FromString("51;50;49");
            
            Node partitioned = new PartitionSolver().Partition(head, 50);
            Assert.Equal("49;51;50;", partitioned.ToString());
        }
    }
}
