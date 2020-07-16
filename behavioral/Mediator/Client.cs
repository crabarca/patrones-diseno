using System;

namespace Mediator
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private ChatRoom _chatRoom;

        public Client(string name)
        {
            Name = name;
        }

        public void EnterChatRoom(ChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
            Id = chatRoom.Register(this);
        }

        public void Broadcast(string message)
        {
            if (_chatRoom != null)
            {
                _chatRoom.Broadcast(Id, message);
            }
        }

        public void Receive(string senderName, string message)
        {
            Console.WriteLine($"{Name} received message from sender {senderName}: {message}");
        }
    }
}