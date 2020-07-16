
namespace rg_ChainOfResponsability
{
  public class MonkeyHandler : BaseHandler
  {
    public override object Handle(object request)
    {
      if ((string)request == "Banana")
      {
        return $"Monkey: I'll eat the {request.ToString()}\n";
      }
      else
      {
        return base.Handle(request);
      }
    }
  }
  public class SquirrelHandler : BaseHandler
  {
    public override object Handle(object request)
    {
      if ((string)request == "Peanut")
      {
        return $"Squirrel: I'll eat the {request.ToString()}\n";
      }
      else
      {
        return base.Handle(request);
      }
    }
  }
  public class DogHandler : BaseHandler
  {
    public override object Handle(object request)
    {
      if ((string)request == "Meat")
      {
        return $"Dog: I'll eat the {request.ToString()}\n";
      }
      else
      {
        return base.Handle(request);
      }
    }
  }
}