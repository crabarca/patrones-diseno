using System.Collections.Generic;

namespace Interpreter
{
    public class Sequence : Expression
    {
        private List<Expression> _expressions;

        public Sequence(List<Expression> expressions)
        {
            _expressions = expressions;
        }

        public override void Interpret(Context context)
        {
            foreach (var expression in _expressions)
            {
                expression.Interpret(context);
                if (!context.Match)
                {
                    break;
                }
            }
        }
    }
}