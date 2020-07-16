using System;

namespace Singleton
{
    public class MySingleton
    {
        public static MySingleton _instance2 = new MySingleton();
        public static Lazy<MySingleton> _lazyInstance = new Lazy<MySingleton>(() => new MySingleton());
        
        private static MySingleton _instance;
        private static object _padlock = new object();

        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new MySingleton();
                    }
                }
            }

            return _instance;
        }
        
        private MySingleton() {}

        private void Configure()
        {
            
        }
        
    }
}