namespace Design_Patterns.SimpleFactory;

internal class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cash payment of {amount:C}");
    }
}
