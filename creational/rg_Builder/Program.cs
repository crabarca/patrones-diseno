using System;

namespace rg_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            Director chef = new Director(pizzaBuilder);

            // Create margherita
            chef.createMargherita(); 
            // Important to add reset logic to the GetPizza method
            // in order to clean up the builder internal state
            Pizza margherita = pizzaBuilder.GetPizza();
            Console.WriteLine(margherita.ListIngredients());

            // Create Napolitana
            chef.createNapolitana();
            Pizza napolitana = pizzaBuilder.GetPizza();
            Console.WriteLine(napolitana.ListIngredients());
        }
    }
}
