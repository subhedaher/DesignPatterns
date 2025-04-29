using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class WhatsAppPoster : SocialMediaPoster
    {
        public override ISocialMediaConnector CreateConnector()
        {
            return new WhatsAppConnector();
        }
    }
}
