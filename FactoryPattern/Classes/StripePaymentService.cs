using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class StripePaymentService : IPaymentService
    {
        public string Pay()
        {
            return "Stripe Payment";
        }
    }
}
