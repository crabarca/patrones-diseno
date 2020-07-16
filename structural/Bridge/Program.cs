using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           var remoteA = new RemoteA();
           var remoteB = new RemoteB();
           
           remoteA.ChannelDownButtonPressed();
           remoteB.ChannelUpButtonPressed();
           
           
           var remoteAPlus = new RemoteAPlus();
           var remoteBPlus = new RemoteBPlus();
           
        }
    }
}