using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class VisaPaymentService : IPaymentService
    {
        public string Pay()
        {
            return "Visa Payment";
        }
    }
}
