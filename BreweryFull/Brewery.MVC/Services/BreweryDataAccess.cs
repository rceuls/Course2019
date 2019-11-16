using System.Collections.Generic;
using System.Linq;
using Brewery.Shared;
using Microsoft.EntityFrameworkCore;

namespace Brewery.MVC
{
  public interface IBreweryDataAccess
  {
    IEnumerable<Shared.Brewery> GetAllBreweries();
    IEnumerable<Shared.Brewery> GetAllBreweriesFull();
    Shared.Brewery GetBreweryById(int id);

    IEnumerable<Beer> GetBeers(int breweryId);
    Beer GetBeerByBreweryAndId(int breweryId, int beerId);
  }

  public class BreweryDataAccess : IBreweryDataAccess
  {
    private BreweryContext _context;

    public BreweryDataAccess(BreweryContext context)
    {
      _context = context;
    }

    public IEnumerable<Shared.Brewery> GetAllBreweries()
    {
      return _context.Breweries;
    }

    public IEnumerable<Shared.Brewery> GetAllBreweriesFull()
    {
      return _context.Breweries
        .Include(brewery => brewery.Beers).ThenInclude(beer => beer.BeerType)
        .Include(brewery => brewery.Owner);
    }

    public Beer GetBeerByBreweryAndId(int breweryId, int beerId)
    {
      return _context.Beers
        .Include(beer => beer.BeerType)
        .FirstOrDefault(x => x.BreweryId == breweryId && x.Id == beerId);
    }

    public IEnumerable<Beer> GetBeers(int breweryId)
    {
      return _context.Breweries
        .Include(brewery => brewery.Beers)
        .FirstOrDefault(x => x.Id == breweryId)?.Beers;
    }

    public Shared.Brewery GetBreweryById(int id)
    {
      return _context.Breweries.FirstOrDefault(x => x.Id == id);
    }
  }
}