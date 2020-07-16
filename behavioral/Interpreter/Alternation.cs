using System;
using System.Collections.Generic;

namespace Interpreter
{
    public class Alternation : Expression
    {
        public List<Expression> _expressions;

        public Alternation(List<Expression> expressions)
        {
            _expressions = expressions;
        }

        public override void Interpret(Context context)
        {
            foreach (var expression in _expressions)
            {
                expression.Interpret(context);
                if (context.Match)
                {
                    break;
                }
            }
        }
    }
}