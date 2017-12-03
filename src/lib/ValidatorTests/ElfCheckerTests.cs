using Xunit;
namespace BSNChecker.ConsoleApp.Tests
{
    public class ElfCheckTests
    {
        [Fact]
        public void elfChecker_ShouldInitialize_WithValidParameters()
        {
            var elfChecker = new ElfChecker();
            Assert.NotNull(elfChecker);
        }

        [Theory]
        [InlineData("784032297")]
        [InlineData("841777047")]
        public void elfCheckerCheck_ShouldReturnTrue_WithValidParameters(string input)
        {
            var elfChecker = new ElfChecker();
            var result = elfChecker.Check(input);
            Assert.True(result);
        }

        [Theory]
        [InlineData("9")]
        [InlineData("123123")]
        [InlineData("1131")]
        public void elfCheckerCheck_ShouldReturnFalse_WithInvalidParameters(string input)
        {
            var elfChecker = new ElfChecker();
            var result = elfChecker.Check(input);
            Assert.False(result);
        }
    }
}
