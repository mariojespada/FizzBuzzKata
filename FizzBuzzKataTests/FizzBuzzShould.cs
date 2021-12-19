using Xunit;

namespace FizzBuzzKataTests
{
    public class FizzBuzzShould
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
        public void return_4_when_number_is_4()
        {
            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.GetFizzBuzz(4);

            Assert.Equal("4", result);
        }
    }
}