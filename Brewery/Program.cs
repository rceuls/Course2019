using System;
using System.Collections.Generic;
using System.Linq;

namespace Brewery
{
  public class Brewery
  {
    public string Name { get; set; }
    public Person Owner { get; set; }
    public ICollection<Person> Investors { get; set; }
    public ICollection<Beer> Beers { get; set; }
  }

  public class Person
  {
    public string FullName => $"{LastName}, ${FirstName}";
    public string LastName { get; set; }
    public string FirstName { get; set; }
  }

  public class Beer
  {
    public string Name { get; set; }
    public BeerType BeerType { get; set; }
  }
  public class BeerType
  {
    public string Description { get; set; }
    public string Name { get; set; }
  }

  public class Program
  {
    static void Main(string[] args)
    {
      var myBrewery = new Brewery()
      {
        Name = "mijn brouwerij"
      };
      var pils = new BeerType { Name = "Pils" };
      var trappist = new BeerType { Name = "Trappist" };

      myBrewery.Beers = new List<Beer>();
      myBrewery.Beers.Add(new Beer() { Name = "Jupiler", BeerType = pils });
      myBrewery.Beers.Add(new Beer() { Name = "Stella", BeerType = pils });

      myBrewery.Beers.ToList().ForEach(x =>
      {
        Console.WriteLine($"{x.Name} - {x.BeerType.Name}");
      });

      pils.Name = "PILSSSSSS";
      myBrewery.Beers.ElementAt(0).BeerType.Name = "PILLLS";

      myBrewery.Beers.ToList().ForEach(x =>
      {
        Console.WriteLine($"{x.Name} - {x.BeerType.Name}");
      });
    }
  }
}
