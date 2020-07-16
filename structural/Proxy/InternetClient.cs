using System;

namespace Proxy
{
    public class InternetClient : IInternet
    {
        public void Connect(string url)
        {
            Console.WriteLine($"Connecting to url: {url}");
        }
    }
}