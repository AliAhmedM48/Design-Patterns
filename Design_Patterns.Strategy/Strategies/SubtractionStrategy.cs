namespace Design_Patterns.Strategy.Strategies;

internal class SubtractionStrategy : IOperationStrategy
{
    public int DoOperation(int num1, int num2)
    {
        return num1 - num2;
    }
}
