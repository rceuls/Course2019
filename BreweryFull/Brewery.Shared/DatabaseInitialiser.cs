using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Brewery.Shared
{
  public interface IDatabaseInitializer
  {
    void Initialize();
  }

  public class DatabaseInitializer : IDatabaseInitializer
  {
    private BreweryContext _context;
    private ILogger<DatabaseInitializer> _logger;
    public DatabaseInitializer(BreweryContext context, ILogger<DatabaseInitializer> logger)
    {
      _context = context;
      _logger = logger;
    }
    public void Initialize()
    {
      try
      {
        if (_context.Database.EnsureCreated())
        {
          AddData();
        }
      }
      catch (Exception ex)
      {
        _logger.LogCritical(ex, "Error occurred while creating database");

      }
    }

    private void AddData()
    {
      var tripel = new BeerType { Name = "Tripel" };
      var pils = new BeerType { Name = "Pils" };
      var brewery = new Brewery()
      {
        Name = "InBev Belgium",
        Owner = new Owner()
        {
          Name = "InBev"
        },
        Beers = new List<Beer> {
          new Beer { Name = "Jupiler", BeerType = pils },
          new Beer { Name = "Tripel Karmeliet ", BeerType = tripel},
          new Beer { Name = "Stella", BeerType = pils }
        }
      };
      _context.Breweries.Add(brewery);

      _context.SaveChanges();
    }
  }
}