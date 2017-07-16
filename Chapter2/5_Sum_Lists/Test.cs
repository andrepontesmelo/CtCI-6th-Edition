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
        public void ShouldCountItemsLinkedList()
        {
            // 1;2;3;
            Node head = Node.FromString("1;2;3;");
            Assert.Equal(3, new SumListsSolver().Count(head));
        }


        [Fact]
        public void ShouldPadZeroLeftLinkedList()
        {
            // 1;2;3;
            Node head = Node.FromString("1;2;3;");
            new SumListsSolver().PadZeroLeft(head, 3);
            Assert.Equal("0;0;0;1;2;3;", head.ToString());
        }

        [Fact]
        public void ShouldSumOneDigitNumber()
        {
            Node a = Node.FromString("2;");
            Node b = Node.FromString("5;");

            Assert.Equal("7;", new SumListsSolver().Sum(a, b).ToString());
        }

        [Fact]
        public void ShouldSumOneDigitNumberFollowUp()
        {
            Node a = Node.FromString("2;");
            Node b = Node.FromString("5;");

            Assert.Equal("7;", new SumListsSolver().SumFollowUp(a, b).ToString());
        }

        [Fact]
        public void ShouldSumOneDigitNumberWithCarrier()
        {
            Node a = Node.FromString("7;");
            Node b = Node.FromString("8;");

            Assert.Equal("5;1;", new SumListsSolver().Sum(a, b).ToString());
        }

        [Fact]
        public void ShouldSumOneDigitNumberWithCarrierFollowUp()
        {
            Node a = Node.FromString("7;");
            Node b = Node.FromString("8;");

            Assert.Equal("1;5;", new SumListsSolver().SumFollowUp(a, b).ToString());
        }

        [Fact]
        public void ShouldSumThreeDigitNumber()
        {
            // 617 
            Node a = Node.FromString("7;1;6;");

            // 295
            Node b = Node.FromString("5;9;2;");

            // 912
            Assert.Equal("2;1;9;", new SumListsSolver().Sum(a, b).ToString());
        }


        [Fact]
        public void ShouldSumThreeDigitNumberFollowUp()
        {
            Node a = Node.FromString("6;1;7;");
            Node b = Node.FromString("2;9;5;");

            Assert.Equal("9;1;2;", new SumListsSolver().SumFollowUp(a, b).ToString());
        }

        [Fact]
        public void ShouldSumDifferentLengthNumbersFollowUp()
        {
            Node a = Node.FromString("9;");
            Node b = Node.FromString("9;9;9;9;");

            // 9 + 9999 = 10008
            Assert.Equal("1;0;0;0;8;", new SumListsSolver().SumFollowUp(a, b).ToString());
        }
    }
}
