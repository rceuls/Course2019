namespace OOCsharp
{
  public class Program
  {
    static void Main(string region = null,
        string session = null,
        string package = null,
        string project = null,
        string[] args = null)
    {
      switch (region)
      {
        case "OO1":
          Basic.RunStuff(null);
          break;
        case "OO2":
          Interfaces.RunStuff(null);
          break;
        case "OO3":
          AbstractClasses.RunStuff(null);
          break;
        case "OO4":
          Polymorphism.RunStuff(null);
          break;
        default:
          break;
      }
    }
  }
}