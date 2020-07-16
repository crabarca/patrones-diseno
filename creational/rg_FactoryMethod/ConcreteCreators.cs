using System;

namespace rg_FactoryMethod
{

  public class ConcreteCreator1 : Creator
  {
    public override IProduct BuildProduct()
    {
        return new ConcreteProduct1();
    }
  }

  public class ConcreteCreator2: Creator
  {
    public override IProduct BuildProduct()
    {
      return new ConcreteProduct2();
    }
  }
}

