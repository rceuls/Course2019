using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brewery.Shared;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Brewery.MVC.Controllers
{
  [Route("/api/breweries")]
  public class BreweryAPIController : Controller
  {
    private readonly BreweryContext _breweryContext;
    private readonly ILogger<BreweryAPIController> _logger;

    public BreweryAPIController(ILogger<BreweryAPIController> logger, BreweryContext breweryContext)
    {
      _breweryContext = breweryContext;
      _logger = logger;
    }

    [Route("")]
    public IActionResult GetAllBreweries()
    {
      return Ok(_breweryContext.Breweries);
    }

    [Route("full")]
    public IActionResult GetAllBreweriesFull()
    {
      // You return a list here, "not found" is not an issue -- an empty list is still a valid list.
      return Ok(_breweryContext.Breweries
        .Include(brewery => brewery.Beers).ThenInclude(beer => beer.BeerType)
        .Include(brewery => brewery.Owner)
      );
    }

    [Route("{id}")]
    public IActionResult GetBrewery(int id)
    {
      // Either you find the brewery or not. If you don't find your resource return a 404 (as per https://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html)
      var brewery = _breweryContext.Breweries.FirstOrDefault(x => x.Id == id);
      return brewery == default(Shared.Brewery) ? (IActionResult)NotFound() : Ok(brewery);
    }

    [Route("{id}/beers")]
    public IActionResult GetBreweryBeers(int id)
    {
      // if you don't find the brewery, return a 404. Again, an empty list is an empty list so empty list of beer is a valid result.
      var brewery = _breweryContext.Breweries
        .Include(brewery => brewery.Beers)
        .FirstOrDefault(x => x.Id == id);
      return brewery == default(Shared.Brewery) ? (IActionResult)NotFound() : Ok(brewery.Beers);
    }


    [Route("{breweryId}/beers/{beerId}")]
    public IActionResult GetBeerDetails(int breweryId, int beerId)
    {
      // this can return two kinds of 404's; one for the non-existing brewery and one for the non-existing beer.
      var beer = _breweryContext.Beers
        .Include(beer => beer.BeerType)
        .FirstOrDefault(x => x.BreweryId == breweryId && x.Id == beerId);
      return beer == default(Shared.Beer) ? (IActionResult)NotFound() : Ok(beer);
    }
  }
}
