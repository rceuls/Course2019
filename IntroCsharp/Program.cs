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
        default:
          break;
      }
    }
  }
}