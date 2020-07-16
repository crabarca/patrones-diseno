using System;

namespace rg_Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        private Singleton() {}

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            
            // Check if s1 == s2
            if (s1 == s2)
            {
                Console.WriteLine("S1 and S2 are equal");
            }
            else 
            {
                Console.WriteLine("Singleton didn't work");
            }
        }
    }
}
