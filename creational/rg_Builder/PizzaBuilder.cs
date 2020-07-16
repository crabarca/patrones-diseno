using System;

namespace rg_Builder
{
    class PizzaBuilder : IBuilder
    {

      private Pizza _pizza = new Pizza();

      public PizzaBuilder()
      {
        this.Reset();
      }

      public void AddPartA()
      {
        this._pizza.Add("Salsa tomates");
      }

      public void AddPartB()
      {
        this._pizza.Add("Queso");
      }

      public void AddPartC()
      {
        this._pizza.Add("Jamon");
      }

      public void Reset()
      {
        this._pizza = new Pizza();
      }

      public Pizza GetPizza()
      {
        var pizza = this._pizza;
        this.Reset();
        return pizza;
      }
    }
}