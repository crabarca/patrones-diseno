using System;

namespace Bridge
{
    public class RemoteA: RemoteImplementation
    {
        public override void ChannelUpButtonPressed()
        {
            Console.WriteLine("Remote A: Channel Up");
        }
        
        public override void ChannelDownButtonPressed()
        {
            Console.WriteLine("Remote A: Channel Down");
        }
    }
}