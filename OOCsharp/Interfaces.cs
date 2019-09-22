#region OO2
using System;

namespace OOCsharp
{
  public class Interfaces
  {
    public static void RunStuff(string[] args)
    {
      var utensil1 = new InterfacedFork("Mopsig");
      var utensil2 = new InterfacedFork("Förnuft");
      var utensil3 = new InterfacedSpoon("Förnuft");
      var utensils = new ICutlery[] { utensil1, utensil2, utensil3 };

      Array.ForEach(utensils, x =>
      {
        Console.WriteLine($"{x.Series} - {x.DoEat()}");
      });

    }
  }

  public interface ICutlery
  {
    string Series { get; }
    string DoEat();
  }

  public class InterfacedFork : ICutlery
  {
    private string _series;
    public InterfacedFork(string series)
    {
      _series = series;
    }

    public string Series => _series;

    public string DoEat()
    {
      return "Poke Poke";
    }
  }

  public class InterfacedSpoon : ICutlery
  {
    private string _series;
    public InterfacedSpoon(string series)
    {
      _series = series;
    }

    public string Series => _series;

    public string DoEat()
    {
      return "Slurp Slurp";
    }
  }
}
#endregion