namespace Design_Patterns.Strategy;

internal class Calculator
{
    private IOperationStrategy _strategy;
    public Calculator(IOperationStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void SetStrategy(IOperationStrategy strategy)
    {
        this._strategy = strategy;
    }

    public int ExecuteOperation(int num1, int num2)
    {
        return this._strategy.DoOperation(num1, num2);
    }

}