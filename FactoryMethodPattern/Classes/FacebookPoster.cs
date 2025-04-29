using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class FacebookPoster : SocialMediaPoster
    {
        public override ISocialMediaConnector CreateConnector()
        {
            return new FacebookConnector();
        }
    }
}
