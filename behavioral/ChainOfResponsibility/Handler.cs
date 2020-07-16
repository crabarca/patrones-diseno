namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _handler;

        public void SetSuccessor(Handler handler)
        {
            _handler = handler;
        }
        
        public abstract void ProcessMessage(Message message);


    }
}