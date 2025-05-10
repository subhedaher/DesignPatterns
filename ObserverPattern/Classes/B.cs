using static ObserverPattern.Classes.A;

namespace ObserverPattern.Classes
{
    public class B : IObserver
    {
        public void ReceiveData(string msg)
        {
            Console.WriteLine("Im Class B, I received Data From A: " + msg);
        }
    }
}
