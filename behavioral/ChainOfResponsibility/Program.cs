using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message("hola garabato SPAM");
            
            var slangFilter = new SlangFilter();
            var spamFilter = new SpamFilter();
            spamFilter.SetSuccessor(slangFilter);
            
            spamFilter.ProcessMessage(message);

            if (message.Valid)
            {
                Console.WriteLine($"Message Received: {message.FilteredText}");
            }
            else
            {
                Console.WriteLine($"This message is spam!");
            }
        }
    }
}