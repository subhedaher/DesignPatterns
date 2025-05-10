using static ObserverPattern.Classes.A;

namespace ObserverPattern.Classes
{
    public class E : IObserver
    {
        public void ReceiveData(string msg)
        {
            Console.WriteLine("Im Class E, I received Data From A: " + msg);
        }
    }
}
