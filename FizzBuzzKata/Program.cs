var numbers = new FizzBuzz();
numbers.PrintNumbers();

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (IsFizz(number) && IsBuzz(number))
            return "FizzBuzz";

        if (IsFizz(number))
            return "Fizz";

        if (IsBuzz(number))
            return "Buzz";

        return number.ToString();
    }

    private bool IsFizz(int number)
    {
        return number % 3 == 0;
    }

    private bool IsBuzz(int number)
    {
        return number % 5 == 0;
    }

    public void PrintNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(GetFizzBuzz(i));
        }
    }
} 