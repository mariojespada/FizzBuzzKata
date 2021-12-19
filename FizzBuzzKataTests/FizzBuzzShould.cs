using Xunit;

namespace FizzBuzzKataTests
{
    public class FizzBuzzShould
    {
        private FizzBuzz _fizzBuzz;
        public FizzBuzzShould()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void return_number_when_number_is_not_multiple_of_3(int number)
        {
            string result = _fizzBuzz.GetFizzBuzz(number);

            Assert.Equal(number.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void return_Fizz_when_number_is_multiple_of_3(int number)
        {
            string result = _fizzBuzz.GetFizzBuzz(number);

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void return_Buzz_when_number_is_multiple_of_5(int number)
        {
            string result = _fizzBuzz.GetFizzBuzz(number);

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void return_Buzz_when_number_is_multiple_of_3_and_5(int number)
        {
            string result = _fizzBuzz.GetFizzBuzz(number);

            Assert.Equal("FizzBuzz", result);
        }
    }
}