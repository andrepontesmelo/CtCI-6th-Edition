using Xunit;

namespace Palindrom.Tests
{
    public class PalindromSolverReverseTests
    {
        [Fact]
        public void ShouldReverseList()
        {
            Node a = Node.FromString("ABC");
            Node reverse = new PalindromSolverReverse().Reverse(a);

            Assert.Equal("CBA", reverse.ToString());
        }

        [Fact]
        public void ShouldCheckSmallPalindrom()
        {
            Node a = Node.FromString("ABA");
            Assert.True(new PalindromSolverReverse().IsPalindrom(a));
        }

        [Fact]
        public void ShouldCheckEmptyString()
        {
            Node a = Node.FromString("");
            Assert.True(new PalindromSolverReverse().IsPalindrom(a));
        }

        [Fact]
        public void ShouldCheckOneCharString()
        {
            Node a = Node.FromString("A");
            Assert.True(new PalindromSolverReverse().IsPalindrom(a));
        }

        [Fact]
        public void ShouldCheckTwoCharsPalindromString()
        {
            Node a = Node.FromString("AA");
            Assert.True(new PalindromSolverReverse().IsPalindrom(a));
        }

        [Fact]
        public void ShouldCheckTwoCharsNotPalindromString()
        {
            Node a = Node.FromString("AB");
            Assert.False(new PalindromSolverReverse().IsPalindrom(a));
        }

    }
}