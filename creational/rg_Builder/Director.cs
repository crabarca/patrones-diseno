using System;

namespace rg_Builder
{

  public class Director
  {

    private IBuilder _builder;
    public Director(IBuilder builder)
    {
      this._builder = builder;
    }

    public void createMargherita(){
      this._builder.AddPartA();
      this._builder.AddPartB();
    }

    public void createNapolitana(){
      this._builder.AddPartA();
      this._builder.AddPartB();
      this._builder.AddPartC();
    }
  }
}