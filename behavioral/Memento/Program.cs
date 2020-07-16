using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordProcessor = new WordProcessor();
            
            wordProcessor.OnInput("Hola ");
            wordProcessor.OnInput("Mundo ");
            wordProcessor.OnInput("!!! ");
            
            wordProcessor.Undo();
            wordProcessor.Undo();
            wordProcessor.Undo();
            wordProcessor.Undo();
            wordProcessor.Redo();
            
            wordProcessor.OnInput("---");
        }
    }
}