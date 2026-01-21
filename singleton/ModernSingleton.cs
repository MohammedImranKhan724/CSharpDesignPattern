namespace Singleton
{
    public sealed class ModernSingleton
    {
        private static readonly Lazy<ModernSingleton> instance = new(() => new ModernSingleton());

        public static ModernSingleton GetInstance()
        {
            return instance.Value;
        }

        private ModernSingleton() { }
    }
}
