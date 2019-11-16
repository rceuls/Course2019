using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brewery.Shared
{
  public class Beer : BaseDbClass
  {
    public string Name { get; set; }
    public int BeerTypeId { get; set; }
    public BeerType BeerType { get; set; }
    public int BreweryId { get; set; }
  }
}
