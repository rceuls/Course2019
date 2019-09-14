using System;
using System.Threading.Tasks;

namespace IntroCsharp
{
  class Program
  {
    static void Main(string region = null,
        string session = null,
        string package = null,
        string project = null,
        string[] args = null)
    {
      switch (region)
      {
        case "HelloWorld":
          HelloWorld.OurMain(null);
          break;
        case "VariableUsage":
          Variables.VariableUsage();
          break;
        case "ConditionalIf":
          Conditionals.ConditionalUsage();
          break;
        case "ConditionalOr":
          Conditionals.ConditionalUsageOr();
          break;
        case "ConditionalSwitch":
          Conditionals.ConditionalUsageSwitch();
          break;
        case "CollectionsArray":
          Collections.CollectionsArray();
          break;
        case "CollectionsList":
          Collections.CollectionsList();
          break;
        case "IteratorsForeach":
          Iterators.IteratorsForeach();
          break;
        case "IteratorsDoWhile":
          Iterators.IteratorsDoWhile();
          break;
        default:
          break;
      }
    }
  }
}