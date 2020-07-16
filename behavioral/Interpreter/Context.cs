namespace Interpreter
{
    public class Context
    {
        // input
        public string Input { get; set; }
        
        // output
        public bool Match { get; set; }

        public Context(string input)
        {
            Input = input;
            Match = true;
        }
    }
}