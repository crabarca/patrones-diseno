using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new InternetClient();
            var proxy = new InternetProxy(client);
            proxy.AddToBlacklist("www.youtube.com");
            proxy.AddToBlacklist("www.facebook.com");
            
            proxy.Connect("www.google.com");
            proxy.Connect("www.youtube.com");
        }
    }
}