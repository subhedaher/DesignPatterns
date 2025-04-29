using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class PayPalPaymentService : IPaymentService
    {
        public string Pay()
        {
            return "PayPal Payment";
        }
    }
}
