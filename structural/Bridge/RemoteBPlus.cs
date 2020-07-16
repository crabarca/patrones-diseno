using System;

namespace Bridge
{
    public class RemoteBPlus: AbstractPlusRemote
    {
        public override void PlayButtonPressed()
        {
            Console.WriteLine("Remote B: Play");
        }

        public override void PauseButtonPressed()
        {
            Console.WriteLine("Remote B: Pause");
        }

        public RemoteBPlus() : base(new RemoteB())
        {
        }
    }
}