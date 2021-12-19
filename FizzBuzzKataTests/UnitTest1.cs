using Xunit;

namespace FizzBuzzKataTests
{
    public class UnitTest1
    {
        [Fact]
        public void return_1_when_number_is_1()
        {
            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.GetFizzBuzz(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void return_2_when_number_is_2()
        {
            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.GetFizzBuzz(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void return_Fizz_when_number_is_3()
        {
            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.GetFizzBuzz(3);

            Assert.Equal("Fizz", result);
        }
    }
}