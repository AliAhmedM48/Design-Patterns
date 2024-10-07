using Design_Patterns.Behavioral.Strategy.Strategies;

namespace Design_Patterns.Behavioral.Strategy;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var calculator = new Calculator(new AdditionStrategy());
        Console.WriteLine($"Addtion: {calculator.ExecuteOperation(5, 6)}");
        calculator.SetStrategy(new SubtractionStrategy());
        Console.WriteLine($"Subtraction: {calculator.ExecuteOperation(5, 6)}");
    }
}