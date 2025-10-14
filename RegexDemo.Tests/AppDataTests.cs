using RegexDemo.Domain;

namespace RegexDemo.Tests
{
    public class AppDataTests
    {
        [Fact]
        public void AppData_Constants_Should_Have_Expected_Values()
        {
            Assert.Equal("Regex Demo", AppData.TITLE);
            Assert.Equal("1.0", AppData.VERSION);
        }

        [Fact]
        public void Should_match_test_but_does_not()
        {
            Assert.Equal("Regex Demo X", AppData.TITLE);
            Assert.Equal("1.8", AppData.VERSION);
        }
    }
}