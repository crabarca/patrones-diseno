namespace Bridge
{
    public abstract class AbstractRemote
    {
        private RemoteImplementation _remoteImplementation;

        protected AbstractRemote(RemoteImplementation remoteImplementation)
        {
            _remoteImplementation = remoteImplementation;
        }

        public void ChannelUpButtonPressed()
        {
            _remoteImplementation.ChannelUpButtonPressed();
        }

        public void ChannelDownButtonPressed()
        {
            _remoteImplementation.ChannelDownButtonPressed();
        }
    }
}