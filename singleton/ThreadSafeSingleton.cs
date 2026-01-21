namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance;

        private static readonly object lockObject = new object();

        private ThreadSafeSingleton() { }
        public static ThreadSafeSingleton GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }
                return instance;
            }
        }

    }
}
