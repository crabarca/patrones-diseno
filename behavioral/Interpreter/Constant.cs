namespace Interpreter
{
    public class Constant : Expression
    {
        private string _text;

        public Constant(string text)
        {
            _text = text;
        }

        public override void Interpret(Context context)
        {
            var index = context.Input.IndexOf(_text);

            if (index == 0)
            {
                context.Input = context.Input.Substring(_text.Length);
                context.Match = true;
            }
            else
            {
                context.Match = false;
            }
        }
    }
}