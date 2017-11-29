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

        [Fact]
        public void elfCheckerCheck_ShouldReturnTrue_WithValidParameters()
        {
            //123456782
            //111222333 .

            var elfChecker = new ElfChecker();
            var result = elfChecker.Check("123456782");
            Assert.True(result);
        }

        [Fact]
        public void elfCheckerCheck_ShouldReturnFalse_WithInvalidParameters()
        {
            var elfChecker = new ElfChecker();
            var result = elfChecker.Check("9");
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
