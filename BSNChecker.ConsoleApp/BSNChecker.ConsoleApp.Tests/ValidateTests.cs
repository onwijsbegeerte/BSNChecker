using Xunit;

namespace BSNChecker.ConsoleApp.Tests
{
    public class ValidateTests
    {
        [Fact]
        public void Validate_ShouldInitialize_WithValidParameters()
        {
            var validate = new Validate();
            Assert.NotNull(validate);
        }
    }
}
