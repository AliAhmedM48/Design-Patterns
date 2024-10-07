using Design_Patterns.SimpleFactory.Payment_Types;

namespace Design_Patterns.SimpleFactory;

internal class PaymentFactory
{
    public IPayment CreatePayment(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.CreditCard:
                return new CreditCardPayment();
            case PaymentType.PayPal:
                return new PayPalPayment();
            case PaymentType.Cash:
                return new CashPayment();
            default:
                throw new ArgumentOutOfRangeException(nameof(paymentType), paymentType, "Invalid payment type");

        }
    }
}
