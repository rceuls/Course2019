using System;

namespace Brewery.Shared
{
  public class Beer
  {
    public int? Id { get; set; }
    public string Name { get; set; }
    public BeerType BeerType { get; set; }
  }
}
