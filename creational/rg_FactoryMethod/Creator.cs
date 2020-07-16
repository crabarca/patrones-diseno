using System;

namespace rg_FactoryMethod
{
    public abstract class Creator
    {
      public abstract IProduct BuildProduct();

      public string PerformOperation()
      {
        // Method to create item
        var product = BuildProduct();

        var result = "Creator: The same creator's code has just worked with "
          + product.Operation();
        return result;
      }
    }
}
