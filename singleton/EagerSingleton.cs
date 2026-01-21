namespace Singleton
{
    public sealed class EagerSingleton
    {
        private static readonly EagerSingleton instance = new EagerSingleton();

        private EagerSingleton()
        {
        }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

        //public static EagerSingleton Instance => instance;
    }
}
