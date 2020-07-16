using System;
using System.Collections.Generic;

namespace rg_ChainOfResponsability
{
    class Client
    {
        public static void ClientCode(BaseHandler handler)
        {
            foreach (var food in new List<string> { "Peanut", "Banana", "Cup of coffee", "Meat" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new MonkeyHandler();
            var dog = new DogHandler();
            var squirrel = new SquirrelHandler();

            monkey.setNext(squirrel).setNext(dog);

            // squirrel.setNext(monkey).setNext(dog);

            Client.ClientCode(monkey);
        }
    }
}
