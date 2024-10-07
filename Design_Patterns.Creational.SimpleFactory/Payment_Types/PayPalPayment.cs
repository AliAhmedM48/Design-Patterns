namespace Design_Patterns.Creational.SimpleFactory.Payment_Types;

internal class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }
}
