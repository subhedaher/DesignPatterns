using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public abstract class SocialMediaPoster
    {

        public void Post(string userName, string password, string content)
        {
            var socialMedia = CreateConnector();
            socialMedia.Login(userName, password);
            socialMedia.Post(content);
            socialMedia.Logout();
        }

        public abstract ISocialMediaConnector CreateConnector();
    }
}
