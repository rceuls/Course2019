using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brewery.MVC.Models;
using System.Collections.Generic;
using Brewery.Shared;

namespace Brewery.MVC.Controllers
{
  public class BeerController : Controller
  {
    private readonly ILogger<BeerController> _logger;

    public BeerController(ILogger<BeerController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      var darkSpecial = new BeerType { Name = "Donker Speciaalbier" };
      var tripel = new BeerType { Name = "Tripel" };
      var amberSpecial = new BeerType { Name = "Amber speciaalbier" };
      var brewery = new Brewery.Shared.Brewery()
      {
        Beers = new List<Beer> {
          new Beer { Name = "Gouden Carolus Classic", BeerType = darkSpecial },
          new Beer { Name = "Gouden Carolus Tripel", BeerType = tripel },
          new Beer { Name = "Gouden Carolus Tripel Versie II", BeerType = tripel },
          new Beer { Name = "Gouden Carolus Ambrio", BeerType = amberSpecial }
        }
      };
      return View(brewery);
    }
  }
}
