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
        public void return_Fizz_when_number_is_3(int number)
        {
            string result = _fizzBuzz.GetFizzBuzz(number);

            Assert.Equal("Fizz", result);
        }
    }
}