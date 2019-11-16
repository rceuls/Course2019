using System.ComponentModel.DataAnnotations.Schema;

namespace Brewery.Shared
{
  public class BaseDbClass
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
  }
}