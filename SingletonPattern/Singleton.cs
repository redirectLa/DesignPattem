namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton singleton = null;
        private Singleton() { }

        private static readonly object lockStr = new object();
        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                lock (lockStr)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }

            }
            return singleton;
        }
    }

    public sealed class StaticSingleton
    {
        private static readonly StaticSingleton singleton = new StaticSingleton();
        private StaticSingleton() { }
        public static StaticSingleton GetInstance()
        {
            return singleton;
        }

    }

}