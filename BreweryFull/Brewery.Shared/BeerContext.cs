using Microsoft.EntityFrameworkCore;

namespace Brewery.Shared
{
  public class BreweryContext : DbContext
  {
    public BreweryContext(DbContextOptions<BreweryContext> options) : base(options)
    {

    }

    public DbSet<Beer> Beers { get; set; }
    public DbSet<BeerType> BeerTypes { get; set; }
    public DbSet<Brewery> Breweries { get; set; }
    public DbSet<Owner> Owners { get; set; }
  }
}