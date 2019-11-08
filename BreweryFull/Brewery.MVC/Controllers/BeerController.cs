using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brewery.MVC.Models;
using Brewery.Shared;
using System.Linq;

namespace Brewery.MVC.Controllers
{
  public class BeerController : Controller
  {
    private readonly BreweryContext _breweryContext;
    private readonly ILogger<BeerController> _logger;

    public BeerController(ILogger<BeerController> logger, BreweryContext breweryContext)
    {
      _breweryContext = breweryContext;
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View(_breweryContext.Breweries);
    }

    public IActionResult Detail(int id)
    {
      var targetBeer = _breweryContext.Breweries.FirstOrDefault().Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      return View(targetBeer);
    }

    public IActionResult Delete(int id)
    {
      var targetBeer = _breweryContext.Breweries.FirstOrDefault().Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      return View(targetBeer);
    }

    [HttpPost]
    public IActionResult DoDelete(int id)
    {
      var targetBeer = _breweryContext.Breweries.FirstOrDefault().Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      _breweryContext.Breweries.FirstOrDefault().Beers.Remove(targetBeer);
      return RedirectToAction(nameof(Index));

    }
  }
}
