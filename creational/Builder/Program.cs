using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var httpRequest = new HttpRequest(new Dictionary<string, string>(){{"content-type", "application/json"}}, "", "GET", "http", "www.google.com", "", "", "", "1.1");
            
            var httpRequest = new HttpRequest.Builder("www.google.com")
                .AddHeader("context-type", "application/json")
                .SetMethod("GET")
                .SetProtocol("http")
                .Build();
        }
    }
}