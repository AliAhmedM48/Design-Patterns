namespace Design_Patterns.SimpleFactory;


internal class Program
{
    static void Main(string[] args)
    {
        PaymentFactory paymentFactory = new PaymentFactory();

        Console.WriteLine("Enter payment type (creditcard, paypal, cash):");
        string? paymentTypeInput = Console.ReadLine();

        Console.WriteLine("Enter amount:");

        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        #region Directly instantiate the payment object based on user input

        //IPayment payment = null;

        //switch (paymentTypeInput.ToLower())
        //{
        //    case "creditcard":
        //        payment = new CreditCardPayment();
        //        break;
        //    case "paypal":
        //        payment = new PayPalPayment();
        //        break;
        //    case "cash":
        //        payment = new CashPayment();
        //        break;
        //    default:
        //        Console.WriteLine("Invalid payment type.");
        //        return;
        //}

        //payment.ProcessPayment(amount);

        #endregion

        if (Enum.TryParse(typeof(PaymentType), paymentTypeInput, true, out var paymentTypeEnum)
            && paymentTypeEnum is PaymentType paymentType)
        {
            IPayment payment = paymentFactory.CreatePayment(paymentType);
            payment.ProcessPayment(amount);

        }
        else
        {
            Console.WriteLine("Invalid payment type.");
        }
    }
}
