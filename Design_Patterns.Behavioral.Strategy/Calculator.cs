namespace Design_Patterns.Behavioral.Strategy;

internal class Calculator
{
    private IOperationStrategy _strategy;
    public Calculator(IOperationStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IOperationStrategy strategy)
    {
        _strategy = strategy;
    }

    public int ExecuteOperation(int num1, int num2)
    {
        return _strategy.DoOperation(num1, num2);
    }

}