#region OO3
using System;

namespace OOCsharp
{
  public class AbstractClasses
  {
    public static void RunStuff(string[] args)
    {
      var utensil1 = new AbstractedFork("Mopsig");
      var utensil2 = new AbstractedFork("Förnuft");
      var utensil3 = new AbstractedSpoon("Förnuft");
      var utensils = new Cutlery[] { utensil1, utensil2, utensil3 };

      Array.ForEach(utensils, x =>
      {
        Console.WriteLine($"{x.Series} - {x.DoEat()}");
      });

    }
  }
  public abstract class Cutlery
  {

    private string _series;
    public Cutlery(string series)
    {
      _series = series;
    }

    public string Series => _series;

    public abstract string DoEat();
  }

  public class AbstractedFork : Cutlery
  {
    public AbstractedFork(string series) : base(series)
    {
    }

    public override string DoEat()
    {
      return "Poke Poke";
    }
  }

  public class AbstractedSpoon : Cutlery
  {
    public AbstractedSpoon(string series) : base(series)
    {
    }

    public override string DoEat()
    {
      return "Spoon spoon";
    }
  }
}
#endregion