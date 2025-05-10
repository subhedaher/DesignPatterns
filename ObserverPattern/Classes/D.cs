using static ObserverPattern.Classes.A;

namespace ObserverPattern.Classes
{
    public class D : IObserver
    {
        public void ReceiveData(string msg)
        {
            Console.WriteLine("Im Class D, I received Data From A: " + msg);
        }
    }
}
