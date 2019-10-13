using System.Collections.Generic;
using Brewery.Shared;

namespace Brewery.MVC.Models
{
  public class BeerDatabase
  {
    private static bool _isInitialized = false;
    private static IEnumerable<BeerType> _beerTypes = null;
    private static Brewery.Shared.Brewery _brewery = null;

    private static void Initialize()
    {
      if (!_isInitialized)
      {
        var darkSpecial = new BeerType { Name = "Donker Speciaalbier" };
        var tripel = new BeerType { Name = "Tripel" };
        var amberSpecial = new BeerType { Name = "Amber speciaalbier" };
        var brewery = new Brewery.Shared.Brewery()
        {
          Beers = new List<Beer> {
          new Beer { Name = "Gouden Carolus Classic", BeerType = darkSpecial, Id = 1 },
          new Beer { Name = "Gouden Carolus Tripel", BeerType = tripel, Id = 2 },
          new Beer { Name = "Gouden Carolus Tripel Versie II", BeerType = tripel, Id = 3 },
          new Beer { Name = "Gouden Carolus Ambrio", BeerType = amberSpecial, Id = 4 }
        }
        };

        _beerTypes = new[] { darkSpecial, tripel, amberSpecial };
        _brewery = brewery;
        _isInitialized = true;
      }
    }

    public static Shared.Brewery Brewery
    {
      get
      {
        Initialize();
        return _brewery;
      }
    }
    public static IEnumerable<BeerType> BeerTypes
    {
      get
      {
        Initialize();
        return _beerTypes;
      }
    }

  }
}
