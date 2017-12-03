using Xunit;

namespace BSNChecker.ConsoleApp.Tests
{
    public class ElfCheckerMock : IElfChecker
    {
        private bool _typeOfElfchecker { get; }
        public ElfCheckerMock(bool typeOfElfchecker)
        {
            _typeOfElfchecker = typeOfElfchecker;
        }
        public bool Check(string input)
        {
            return _typeOfElfchecker;
        }
    }

    public class ValidatorTests
    {

        [Fact]
        public void Validate_ShouldInitialize_WithValidParameters()
        {
            var validator = new BSNValidator(new ElfCheckerMock(true));
            Assert.NotNull(validator);
        }

        [Fact]
        public void Validate_ShouldReturnTrue_WithValidParameters()
        {
            var validator = new BSNValidator(new ElfCheckerMock(true));
            Assert.True(validator.Validate("000000000"));
        }

        [Fact]
        public void Validate_ShouldReturnFalse_WithToShortInput()
        {
            var validator = new BSNValidator(new ElfCheckerMock(false));
            Assert.False(validator.Validate("0000"));
        }

        [Fact]
        public void Validate_ShouldReturnFalse_InvalidParameters()
        {
            var validator = new BSNValidator(new ElfCheckerMock(false));
            Assert.False(validator.Validate("asdasdasd"));
        }
    }
}
