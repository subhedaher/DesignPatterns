using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class WhatsAppConnector : ISocialMediaConnector
    {
        public void Login(string userName, string password)
        {
            Console.WriteLine("Logging to WhatsApp");
        }

        public void Logout()
        {
            Console.WriteLine("Logging out from WhatsApp");
        }

        public void Post(string content)
        {
            Console.WriteLine($"Posting {content} on WhatsApp");
        }
    }
}
