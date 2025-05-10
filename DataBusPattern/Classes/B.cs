using static DataBusPattern.Classes.DataBus;

namespace DataBusPattern.Classes
{
    public class B : ISubscriber
    {
        public void DataReceived<T>(BusMessage<T> busMessage)
        {
            Console.WriteLine("Im Class B, I Recived Data From " + busMessage.Sender.GetType().ToString() + " Is: " + busMessage.Data!.ToString());
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
