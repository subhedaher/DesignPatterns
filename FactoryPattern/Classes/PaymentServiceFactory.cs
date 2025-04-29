using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class PaymentServiceFactory
    {
        public static IPaymentService CreatePaymentService(int method)
        {
            return method switch
            {
                1 => new PayPalPaymentService(),
                2 => new StripePaymentService(),
                3 => new VisaPaymentService(),
                _ => throw new ArgumentException("Invalid payment method."),
            };
        }
    }
}
