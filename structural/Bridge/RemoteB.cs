using System;

namespace Bridge
{
    public class RemoteB: RemoteImplementation
    {
        public override void ChannelUpButtonPressed()
        {
            Console.WriteLine("Remote B: Channel Up");
        }
        
        public override void ChannelDownButtonPressed()
        {
            Console.WriteLine("Remote B: Channel Down");
        }
    }
}