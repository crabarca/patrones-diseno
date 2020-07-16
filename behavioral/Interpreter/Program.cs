using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var alternation = new Alternation(new List<Expression>()
            {
                new Constant("b"),
                new Constant("cd"),
                new Constant("e")
            });
            var iteration = new Iteration(alternation);
            
            var sequence = new Sequence(new List<Expression>()
            {
                new Constant("a"),
                iteration,
                new Constant("f")
            });
            
            var root = new Root(sequence);
            
            var context = new Context("afafafaf");
            root.Interpret(context);
            
            Console.WriteLine($"Match : {context.Match}");
        }
    }
}