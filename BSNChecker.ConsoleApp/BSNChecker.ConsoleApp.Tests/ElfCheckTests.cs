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
        [InlineData("736160221")]
        [InlineData("111222333")]
        [InlineData("614649328")]
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

        [Theory]
        [InlineData("9", 9)]
        [InlineData("99", 27)]
        [InlineData("736160221", 176)]
        public void elfCheckerMultiply_ShouldReturnValidNumber_WithValidParameters(string input, int expected)
        {
            var elfChecker = new ElfChecker();
            int result = elfChecker.Multiply(input);
            Assert.Equal(expected, result);
        }
    }
}
