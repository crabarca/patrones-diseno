using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = MySingleton.GetInstance();
            var singleton2 = MySingleton.GetInstance();

            var singleton3 = MySingleton._lazyInstance.Value;
        }
    }
}