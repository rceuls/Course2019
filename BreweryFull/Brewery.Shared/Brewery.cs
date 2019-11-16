using System;
using System.Collections.Generic;

namespace Brewery.Shared
{
  public class Brewery : BaseDbClass
  {
    public int OwnerId { get; set; }
    public ICollection<Beer> Beers { get; set; }
    public Owner Owner { get; set; }
    public string Name { get; set; }
  }
}
