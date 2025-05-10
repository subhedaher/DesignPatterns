namespace DataBusPattern.Classes
{
    public class DataBus
    {
        private static DataBus Instance = null;
        public HashSet<ISubscriber> Subscribers;
        private DataBus()
        {
            Subscribers = new HashSet<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Published<T>(BusMessage<T> busMessage)
        {
            foreach (var subscriber in Subscribers)
            {
                if (subscriber != busMessage.Sender)
                {
                    subscriber.DataReceived(busMessage);
                }
            }
        }

        public static DataBus GetInstance()
        {
            if (Instance == null)
                Instance = new DataBus();
            return Instance;
        }


        public class BusMessage<T>
        {
            public T Data { get; set; }
            public ISubscriber Sender { get; set; }

        }

        public interface ISubscriber
        {
            void DataReceived<T>(BusMessage<T> busMessage);
        }

    }
}
