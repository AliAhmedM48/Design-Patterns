namespace Design_Patterns.SimpleFactory.Payment_Types;

internal class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cash payment of {amount:C}");
    }
}
