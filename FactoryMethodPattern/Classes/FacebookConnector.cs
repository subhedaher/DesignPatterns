using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class FacebookConnector : ISocialMediaConnector
    {
        public void Login(string userName, string password)
        {
            Console.WriteLine($"Logging into Facebook as {userName}");
        }

        public void Post(string content)
        {
            Console.WriteLine($"Posting '{content}' to Facebook");
        }

        public void Logout()
        {
            Console.WriteLine("Logging out of Facebook");
        }
    }

}
