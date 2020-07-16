using System;
using System.Collections.Generic;

namespace Proxy
{
    public class InternetProxy : IInternet
    {
        private InternetClient _client;
        private List<string> _blacklist;

        public InternetProxy(InternetClient client)
        {
            _client = client;
            _blacklist = new List<string>();
        }

        public void Connect(string url)
        {
            if (_blacklist.Contains(url))
            {
                throw new Exception("Unauthorized Access!");
            }
            _client.Connect(url);
        }

        public void AddToBlacklist(string url)
        {
            _blacklist.Add(url);
        }
    }
}