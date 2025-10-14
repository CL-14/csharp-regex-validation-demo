using RegexDemo.Domain;

namespace RegexDemo.Tests
{
    public class AppDataTests
    {
        //[Fact]
        //public void AppData_Constants_Should_Have_Expected_Values()
        //{
        //    Assert.Equal("Regex Demo", AppData.TITLE);
        //    Assert.Equal("1.0", AppData.VERSION);
        //}

        //[Fact]
        //public void Should_match_test_but_does_not()
        //{
        //    Assert.Equal("Regex Demo X", AppData.TITLE);
        //    Assert.Equal("1.8", AppData.VERSION);
        //}

        [Theory]
        [InlineData("12345", true)]
        [InlineData("123a45", false)]
        [InlineData("", false)]
        public void IsOnlyDigits(string input, bool expected)
        {
            Assert.Equal(expected, RegexHelperService.IsOnlyDigits(input));
        }
        [Theory]
        [InlineData("abcde", true)]
        [InlineData("abcDe", false)]
        [InlineData("abcd3", false)]
        [InlineData("", false)]
        public void IsOnlyLowercaseLetters(string input, bool expected)
        {
            Assert.Equal(expected, RegexHelperService.IsOnlyLowercaseLetters(input));
        }
        [Theory]
        [InlineData("Hello", true)]
        [InlineData("hello", false)]
        [InlineData("1hello", false)]
        [InlineData("", false)]
        public void StartsWithCapital(string input, bool expected)
        {
            Assert.Equal(expected, RegexHelperService.StartsWithCapital(input));
        }

        [Theory]
        [InlineData("abc-def-gh1", true)]
        [InlineData("123-456-789", true)]
        [InlineData("abc-123-def", true)]
        [InlineData("abc_def_gh1", false)]
        [InlineData("abcdefg", false)]
        [InlineData("", false)]
        public void IsValidPattern(string input, bool expected)
        {
            Assert.Equal(expected, RegexHelperService.IsValidPattern(input));
        }

        [Theory]
        [InlineData("A65 F4E2", true)]
        [InlineData("D02X285", false)]
        [InlineData("a65 f4e2", true)]
        [InlineData("D02x285", false)]
        [InlineData("123 4567", false)]
        [InlineData("AB1 C2D3", false)]
        [InlineData("A6 5F4E2", false)]
        [InlineData("", false)]
        public void EircodeIsValid(string input, bool expected)
        {
            Assert.Equal(expected, RegexHelperService.EircodeIsValid(input));
        }
    }
}