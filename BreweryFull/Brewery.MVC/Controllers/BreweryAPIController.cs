using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brewery.Shared;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Brewery.MVC.Controllers
{
  [Route("/api/breweries")]
  public class BreweryAPIController : Controller
  {
    private readonly IBreweryDataAccess _dataAccess;
    private readonly ILogger<BreweryAPIController> _logger;

    public BreweryAPIController(ILogger<BreweryAPIController> logger, IBreweryDataAccess dataAccess)
    {
      _dataAccess = dataAccess;
      _logger = logger;
    }

    [Route("")]
    public IActionResult GetAllBreweries()
    {
      return Ok(_dataAccess.GetAllBreweries());
    }

    [Route("full")]
    public IActionResult GetAllBreweriesFull()
    {
      // You return a list here, "not found" is not an issue -- an empty list is still a valid list.
      return Ok(_dataAccess.GetAllBreweriesFull());
    }

    [Route("{id}")]
    public IActionResult GetBrewery(int id)
    {
      // Either you find the brewery or not. If you don't find your resource return a 404 (as per https://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html)
      var brewery = _dataAccess.GetBreweryById(id); ;
      return brewery == default(Shared.Brewery) ? (IActionResult)NotFound() : Ok(brewery);
    }

    [Route("{id}/beers")]
    public IActionResult GetBreweryBeers(int id)
    {
      // if you don't find the brewery, return a 404. Again, an empty list is an empty list so empty list of beer is a valid result.
      var beers = _dataAccess.GetBeers(id);
      return beers == default(IEnumerable<Beer>) ? (IActionResult)NotFound() : Ok(beers);
    }


    [Route("{breweryId}/beers/{beerId}")]
    public IActionResult GetBeerDetails(int breweryId, int beerId)
    {
      // this can return two kinds of 404's; one for the non-existing brewery and one for the non-existing beer.
      var beer = _dataAccess.GetBeerByBreweryAndId(breweryId, beerId);
      return beer == default(Shared.Beer) ? (IActionResult)NotFound() : Ok(beer);
    }
  }
}
