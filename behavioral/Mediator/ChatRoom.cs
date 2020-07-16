using System.Collections.Generic;

namespace Mediator
{
    public class ChatRoom
    {
        private int _counter = 1;
        private Dictionary<int, Client> _clients;

        public ChatRoom()
        {
            _clients = new Dictionary<int, Client>();
        }

        public int Register(Client client)
        {
            int id = _counter;
            _clients[id] = client;
            _counter++;
            return id;
        }

        public void Broadcast(int senderId, string message)
        {
            var sender = _clients[senderId];
            foreach (var client in _clients.Values)
            {
                if (client.Id != senderId)
                {
                    client.Receive(sender.Name, message);
                }
            }
        }
        
    }
}