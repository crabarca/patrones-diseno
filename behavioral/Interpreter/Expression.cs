namespace Interpreter
{
    public abstract class Expression
    {
        public abstract void Interpret(Context context);
    }
}