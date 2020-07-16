using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = new Client("Alvaro");
            var client2 = new Client("Bruno");
            
            var chatRoom = new ChatRoom();
            client1.EnterChatRoom(chatRoom);
            client2.EnterChatRoom(chatRoom);
            
            client1.Broadcast("Hola!");
            client2.Broadcast("Que tal?");
        }
    }
}