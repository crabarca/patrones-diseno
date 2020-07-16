
namespace rg_ChainOfResponsability
{
  public interface Ihandler
  {
     Ihandler setNext(Ihandler handler);
     object Handle(object Handle);
  }
}