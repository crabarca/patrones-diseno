
namespace rg_ChainOfResponsability
{
  public abstract class BaseHandler : Ihandler
  {
    private Ihandler _nextHandler; 
    public Ihandler setNext(Ihandler handler)
    {
      this._nextHandler = handler;
      return handler;
    }

    public virtual object Handle(object request)
    {
      if (this._nextHandler != null)
      {
        return this._nextHandler.Handle(request);
      }
      else
      {
        return null;
      }
    }
  }
}