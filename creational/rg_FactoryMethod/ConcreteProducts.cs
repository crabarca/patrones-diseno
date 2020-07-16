using System;

namespace rg_FactoryMethod
{
  public class ConcreteProduct1 : IProduct
  {
    public string Operation()
    {
      return "Product 1 operation";
    }
  }


  public class ConcreteProduct2 : IProduct
  {
    public string Operation()
    {
      return "Product 2 operation";
    }
  }

}
