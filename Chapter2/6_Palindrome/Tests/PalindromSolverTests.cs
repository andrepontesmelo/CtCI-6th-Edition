using Xunit;

namespace Palindrom.Tests
{
    public class PalindromSolverTests
    {
        [Fact]
        public void ShouldParsePalindrom()
        {
            Node palindrom = PalindromSolver.FromString("ABA");
            Assert.Equal("ABA", palindrom.ToString());
        }
    }
}
