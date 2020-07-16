
namespace rg_AbstractFactory
{

  public interface IProductB
  {
     string printProductB(); 
  }

  public class ProductB1 : IProductB
  {
    public string printProductB()
    {
      return "This is product B1 ";
    }
  }

  public class ProductB2: IProductB
  {
    public string printProductB(){
      return "This is product B2";
    }
  }
}