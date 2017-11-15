using Xunit;

namespace BSNChecker.ConsoleApp.Tests
{
    public class ValidateTests
    {
        [Fact]
        public void Validate_ShouldInitialize_WithValidParameters()
        {
            var validator = new Validator();
            Assert.NotNull(validator);
        }

        [Fact]
        public void Validate_ShouldReturnTrue_WithValidParameters()
        {
            var validator = new Validator();
            Assert.True(validator.ValidateBsnNumber("000000000"));
        }

        [Fact]
        public void Validate_ShouldReturnFalse_WithInvalidParameters()
        {
            var validator = new Validator();
            Assert.False(validator.ValidateBsnNumber("0000"));
        }

        [Fact]
        public void Validate_ShouldReturnFalse_InvalidParameters()
        {
            var validator = new Validator();
            Assert.False(validator.ValidateBsnNumber("asdasdasd"));
        }
    }
}
