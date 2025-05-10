using static DataBusPattern.Classes.DataBus;

namespace DataBusPattern.Classes
{
    public class C : ISubscriber
    {
        public void DataReceived<T>(BusMessage<T> busMessage)
        {
            Console.WriteLine("Im Class C, I Recived Data From " + busMessage.Sender.GetType().ToString() + " Is: " + busMessage.Data!.ToString());
        }

        public void DataSend<T>(T data)
        {
            BusMessage<T> busMessage = new BusMessage<T>();
            busMessage.Data = data;
            busMessage.Sender = this;
            GetInstance().Published(busMessage);
        }
    }
}
