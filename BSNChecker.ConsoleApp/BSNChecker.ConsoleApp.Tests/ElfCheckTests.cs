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
    }
}
