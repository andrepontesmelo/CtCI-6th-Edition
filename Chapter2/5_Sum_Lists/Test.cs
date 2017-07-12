using System;
using Xunit;

namespace SumLists
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
        public void ShouldSumOneDigitNumber()
        {
            Node a = Node.FromString("2;");
            Node b = Node.FromString("5;");

            Assert.Equal("7;", new SumListsSolver().Sum(a, b).ToString());
        }

        [Fact]
        public void ShouldSumOneDigitNumberWithCarrier()
        {
            Node a = Node.FromString("7;");
            Node b = Node.FromString("8;");

            Assert.Equal("5;1;", new SumListsSolver().Sum(a, b).ToString());
        }

        [Fact]
        public void ShouldSumThreeDigitNumber()
        {
            Node a = Node.FromString("7;1;6;");
            Node b = Node.FromString("5;9;2;");

            Assert.Equal("2;1;9;", new SumListsSolver().Sum(a, b).ToString());
        }
    }
}
