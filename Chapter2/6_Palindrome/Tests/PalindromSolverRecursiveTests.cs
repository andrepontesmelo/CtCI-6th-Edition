using Xunit;

namespace Palindrom.Tests
{
    public class PalindromSolverRecursiveTests
    {
        [Fact]
        public void ShouldCountString()
        {
            Assert.Equal(3, PalindromSolverRecursive.FromString("ABC").Count());
        }

        [Fact]
        public void ShouldCheckSmallestPalindrom()
        {
            var a = PalindromSolverRecursive.FromString("AA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckSmallestNotPalindrom()
        {
            var a = PalindromSolverRecursive.FromString("AB");
            Assert.False(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckBigPalindromEven()
        {
            var a = PalindromSolverRecursive.FromString("ABCCBA");
            Assert.True(a.IsPalindrom());
        }


        [Fact]
        public void ShouldCheckSmallestPalindromOdd()
        {
            var a = PalindromSolverRecursive.FromString("ABA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckBigPalindromOdd()
        {
            var a = PalindromSolverRecursive.FromString("XWABAWX");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckSmallestNotPalindromOdd()
        {
            var a = PalindromSolverRecursive.FromString("AWC");
            Assert.False(a.IsPalindrom());
        }


        [Fact]
        public void ShouldCheckSingleCharacter()
        {
            var a = PalindromSolverRecursive.FromString("A");
            Assert.True(a.IsPalindrom());
        }
    }
}