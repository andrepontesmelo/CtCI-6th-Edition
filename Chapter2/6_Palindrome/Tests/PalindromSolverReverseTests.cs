using Xunit;

namespace Palindrom.Tests
{
    public class PalindromSolverReverseTests
    {
        [Fact]
        public void ShouldParsePalindrom()
        {
            PalindromSolverReverse palindrom = PalindromSolverReverse.FromString("ABA");
            Assert.Equal("ABA", palindrom.ToString());
        }

        [Fact]
        public void ShouldCheckMatches()
        {
            PalindromSolverReverse a = PalindromSolverReverse.FromString("ABC");
            PalindromSolverReverse b = PalindromSolverReverse.FromString("ABC");

            Assert.True(a.Matches(b));
        }

        [Fact]
        public void ShouldCheckNotMatchesDiffSize()
        {
            PalindromSolverReverse a = PalindromSolverReverse.FromString("ABC");
            PalindromSolverReverse b = PalindromSolverReverse.FromString("ABCD");

            Assert.False(a.Matches(b));
        }

        [Fact]
        public void ShouldCheckNotMatchesSameSize()
        {
            PalindromSolverReverse a = PalindromSolverReverse.FromString("ABC");
            PalindromSolverReverse b = PalindromSolverReverse.FromString("ABZ");

            Assert.False(a.Matches(b));
        }

        [Fact]
        public void ShouldCheckMatchesEmpty()
        {
            PalindromSolverReverse a = PalindromSolverReverse.FromString("");
            PalindromSolverReverse b = PalindromSolverReverse.FromString("");

            Assert.True(a.Matches(b));
        }

        [Fact]
        public void ShouldReverseList()
        {
            var a = PalindromSolverReverse.FromString("ABC");
            Node reverse = a.Reverse();

            Assert.Equal("CBA", reverse.ToString());
        }

        [Fact]
        public void ShouldCheckSmallPalindrom()
        {
            var a = PalindromSolverReverse.FromString("ABA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckEmptyString()
        {
            var a = PalindromSolverReverse.FromString("");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckOneCharString()
        {
            var a = PalindromSolverReverse.FromString("A");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckTwoCharsPalindromString()
        {
            var a = PalindromSolverReverse.FromString("AA");
            Assert.True(a.IsPalindrom());
        }

        [Fact]
        public void ShouldCheckTwoCharsNotPalindromString()
        {
            var a = PalindromSolverReverse.FromString("AB");
            Assert.False(a.IsPalindrom());
        }
    }
}