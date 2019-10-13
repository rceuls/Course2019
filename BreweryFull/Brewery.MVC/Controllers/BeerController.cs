using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brewery.MVC.Models;
using Brewery.Shared;
using System.Linq;

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
      return View(BeerDatabase.Brewery);
    }

    public IActionResult Detail(int id)
    {
      var targetBeer = BeerDatabase.Brewery.Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      return View(targetBeer);
    }

    public IActionResult Delete(int id)
    {
      var targetBeer = BeerDatabase.Brewery.Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      return View(targetBeer);
    }

    [HttpPost]
    public IActionResult DoDelete(int id)
    {
      var targetBeer = BeerDatabase.Brewery.Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      BeerDatabase.Brewery.Beers.Remove(targetBeer);
      return RedirectToAction(nameof(Index));

    }
  }
}
