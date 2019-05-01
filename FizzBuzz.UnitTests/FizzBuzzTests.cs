using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void Convert_Number_ReturnsNumberAsString(int number, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Convert(number);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void Convert_MultipleOf3_ReturnsFizz(int number, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Convert(number);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        public void Convert_MultipleOf5_ReturnsBuzz(int number, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Convert(number);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void Convert_MultipleOf3And5_ReturnsFizzBuzz(int number, string expectedResult)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Convert(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
