using System;

namespace Bridge
{
    public class RemoteAPlus: AbstractPlusRemote
    {
        public override void PlayButtonPressed()
        {
            Console.WriteLine("Remote A: Play");
        }

        public override void PauseButtonPressed()
        {
            Console.WriteLine("Remote A: Pause");
        }

        public RemoteAPlus() : base(new RemoteA())
        {
        }
    }
}