#region OO1
using System;

namespace OOCsharp
{
  public class Basic
  {
    public static void RunStuff(string[] args)
    {
      var forkOne = new Fork(1, "Mopsig");
      var forkTwo = new Fork(2, "Förnuft");

      Console.WriteLine($"Going to eat with {forkOne.Series}");
      forkOne.EatPotato();
      Console.WriteLine($"Going to eat with {forkTwo.Series}");
      forkTwo.EatPotato();

      var spoonOne = new Spoon(1, "Dragon");
      var spoonTwo = new Spoon(2, "Martorp");

      Console.WriteLine($"Going to eat with {spoonOne.Series}");
      spoonOne.EatSoup();
      Console.WriteLine($"Going to eat with {spoonTwo.Series}");
      spoonTwo.EatSoup();
    }
  }

  public class Fork
  {
    public Fork(int id, string series)
    {
      Series = series;
      Id = id;
    }
    public int Id { get; set; }
    public string Series { get; set; }
    public void EatPotato()
    {
      Console.WriteLine($"Munchmunch - {Id} - {Series}");
    }
  }

  public class Spoon
  {
    public Spoon(int id, string series)
    {
      Id = id;
      Series = series;
    }

    public int Id { get; set; }
    public string Series { get; set; }
    public void EatSoup()
    {
      Console.WriteLine($"Slurp - {Id} - {Series}");
    }
  }
}
#endregion