namespace ChainOfResponsibility
{
    public class SpamFilter : Handler
    {
        public override void ProcessMessage(Message message)
        {
            if (message.Text.Contains("SPAM"))
            {
                message.Valid = false;
            }

            if (_handler != null)
            {
                _handler.ProcessMessage(message);
            }
        }
    }
}