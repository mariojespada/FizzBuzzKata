// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (isFizz(number))
            return "Fizz";
        
        return number.ToString();
    }

    private bool isFizz(int number)
    {
        return number % 3 == 0;
    }
} 