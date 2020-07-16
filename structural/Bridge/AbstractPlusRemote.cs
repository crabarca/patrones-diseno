namespace Bridge
{
    public abstract class AbstractPlusRemote: AbstractRemote
    {
        public abstract void PlayButtonPressed();

        public abstract void PauseButtonPressed();

        protected AbstractPlusRemote(RemoteImplementation remoteImplementation) : base(remoteImplementation)
        {
        }
    }
}