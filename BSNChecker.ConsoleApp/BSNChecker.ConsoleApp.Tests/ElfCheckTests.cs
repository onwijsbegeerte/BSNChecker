using Xunit;
namespace BSNChecker.ConsoleApp.Tests
{
    public class ElfCheckTests
    {
        [Fact]
        public void Validate_ShouldInitialize_WithValidParameters()
        {
            var elfChecker = new ElfChecker();
            Assert.NotNull(elfChecker);
        }
    }
}
