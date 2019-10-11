using System;
using System.Collections.Generic;

namespace Brewery.Shared
{
  public class Brewery
  {
    public List<Beer> Beers { get; set; }
    public Owner Owner { get; set; }
    public string Name { get; set; }
  }
}
