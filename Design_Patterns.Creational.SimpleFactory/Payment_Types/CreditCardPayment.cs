namespace Design_Patterns.Creational.SimpleFactory.Payment_Types;

internal class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }
}
