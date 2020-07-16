using System.Runtime.InteropServices;

namespace ChainOfResponsibility
{
    public class SlangFilter : Handler
    {
        public override void ProcessMessage(Message message)
        {
            if (message.Text.Contains("garabato"))
            {
                message.FilteredText = message.Text.Replace("garabato", "***");
            }

            if (_handler != null)
            {
                _handler.ProcessMessage(message);
            }
        }
    }
}