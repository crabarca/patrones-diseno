
namespace rg_AbstractFactory
{

  public interface IProductA
  {
     string printProductA(); 
  }

  public class ProductA1 : IProductA
  {
    public string printProductA()
    {
      return "This is product A1 ";
    }
  }

  public class ProductA2: IProductA
  {
    public string printProductA(){
      return "This is product A2";
    }
  }
}