namespace FactoryMethodPattern.Interfaces
{
    public interface ISocialMediaConnector
    {
        void Login(string userName, string password);
        void Post(string content);
        void Logout();
    }
}
