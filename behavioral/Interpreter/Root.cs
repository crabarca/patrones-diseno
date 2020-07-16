namespace Interpreter
{
    public class Root
    {
        private Expression _expression;

        public Root(Expression expression)
        {
            _expression = expression;
        }

        public void Interpret(Context context)
        {
            _expression.Interpret(context);

            if (context.Input.Length > 0)
            {
                context.Match = false;
            }
        }
    }
}