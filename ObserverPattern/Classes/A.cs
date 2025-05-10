namespace ObserverPattern.Classes
{
    public class A
    {

        public HashSet<IObserver> observers;

        public A()
        {
            observers = new HashSet<IObserver>();
        }

        public void AddSubscriber(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveSubscriber(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NewData(string msg)
        {
            foreach (var observer in observers)
            {
                observer.ReceiveData(msg);
            }
        }

        public interface IObserver
        {
            public void ReceiveData(string msg);
        }
    }
}
