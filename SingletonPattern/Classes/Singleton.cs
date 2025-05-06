namespace SingletonPattern.Classes
{
    public class Singleton
    {
        private static Singleton Instance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
        }
    }
}
