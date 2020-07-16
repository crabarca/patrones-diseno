namespace Interpreter
{
    public class Iteration : Expression
    {
        private Expression _expression;

        public Iteration(Expression expression)
        {
            _expression = expression;
        }

        public override void Interpret(Context context)
        {
            while (context.Match)
            {
                _expression.Interpret(context);
            }

            context.Match = true;
        }
    }
}