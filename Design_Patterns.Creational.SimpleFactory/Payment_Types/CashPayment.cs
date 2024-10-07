namespace Design_Patterns.Creational.SimpleFactory.Payment_Types;

internal class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cash payment of {amount:C}");
    }
}
