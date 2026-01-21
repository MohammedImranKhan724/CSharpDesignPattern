namespace Singleton
{
    public sealed class DoubleCheckedLockingSingleton
    {
        private static volatile DoubleCheckedLockingSingleton instance;

        private static readonly object lockObject = new object();

        private DoubleCheckedLockingSingleton() { }

        public static DoubleCheckedLockingSingleton GetInstance()
        {
            if (instance is null)
            {
                lock (lockObject)
                {
                    if (instance is null)
                    {
                        instance = new DoubleCheckedLockingSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
