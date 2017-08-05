using Xunit;

namespace Palindrom.Tests
{
    public class PalindromSolverStackTests
    {
        [Fact]
        public void ShouldCountList()
        {
            var a = PalindromSolverStack.FromString("ABC");
            Assert.Equal(3, a.Count());
        }

        [Fact]
        public void ShouldCheckEvenStringIsPalindrom()
        {
            var a = PalindromSolverStack.FromString("ABBA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckOddStringIsPalindrom()
        {
            var a = PalindromSolverStack.FromString("ABXBA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckStringIsNotPalindrom()
        {
            var a = PalindromSolverStack.FromString("ABXBAW");
            Assert.False(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckSmallStringIsNotPalindrom()
        {
            var a = PalindromSolverStack.FromString("AB");
            Assert.False(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckSmallStringIsPalindrom()
        {
            var a = PalindromSolverStack.FromString("AA");
            Assert.True(a.IsPalindrom());
        }
    }
}