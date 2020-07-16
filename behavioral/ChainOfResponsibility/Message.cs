namespace ChainOfResponsibility
{
    public class Message
    {
        public string Text { get; set; }
        
        public string FilteredText { get; set; }
        
        public bool Valid { get; set; }

        public Message(string text)
        {
            Text = text;
            FilteredText = text;
            Valid = true;
        }
    }
}