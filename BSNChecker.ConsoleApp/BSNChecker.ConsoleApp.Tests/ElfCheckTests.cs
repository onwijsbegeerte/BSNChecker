using Xunit;
namespace BSNChecker.ConsoleApp.Tests
{
    public class ElfCheckTests
    {
        private ElfChecker _ElfChecker;
        public ElfCheckTests()
        {
            var _ElfChecker = new ElfChecker();
        }
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

        [Fact]
        public void elfCheckerMultiply_ShouldReturnValidNumber_WithValidParameters()
        {
            var elfChecker = new ElfChecker();
            var result = elfChecker.Multiply("9");
            Assert.Equal(9, result);
        }
    }
}
