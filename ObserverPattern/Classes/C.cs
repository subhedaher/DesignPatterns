using static ObserverPattern.Classes.A;

namespace ObserverPattern.Classes
{
    public class C : IObserver
    {
        public void ReceiveData(string msg)
        {
            Console.WriteLine("Im Class C, I received Data From A: " + msg);
        }
    }
}
