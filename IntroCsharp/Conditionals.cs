using System;

namespace IntroCsharp
{
  public class Conditionals
  {
    public static void ConditionalUsage()
    {
      #region ConditionalIf
      var date = new DateTime(2019, 09, 18);
      if (date.DayOfWeek == DayOfWeek.Sunday)
      {
        Console.WriteLine("Weekend");
      }
      else if (date.DayOfWeek == DayOfWeek.Saturday)
      {
        Console.WriteLine("Weekend");
      }
      else
      {
        Console.WriteLine("Weekdag");
      }

      #endregion
    }

    public static void ConditionalUsageOr()
    {
      #region ConditionalOr
      var date = new DateTime(2019, 09, 18);
      if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
      {
        Console.WriteLine("Weekend");
      }
      else
      {
        Console.WriteLine("Weekdag");
      }

      #endregion
    }

    public static void ConditionalUsageSwitch()
    {
      #region ConditionalSwitch
      var date = new DateTime(2019, 09, 18);
      switch (date.DayOfWeek)
      {
        case DayOfWeek.Saturday:
          Console.WriteLine("Weekend");
          break;
        case DayOfWeek.Sunday:
          Console.WriteLine("Weekend");
          break;
        case DayOfWeek.Monday:
          Console.WriteLine("Weekdag");
          break;
        case DayOfWeek.Tuesday:
          Console.WriteLine("Weekdag");
          break;
        case DayOfWeek.Wednesday:
          Console.WriteLine("Weekdag");
          break;
        case DayOfWeek.Thursday:
          Console.WriteLine("Weekdag");
          break;
        case DayOfWeek.Friday:
          Console.WriteLine("Weekdag");
          break;
        default:
          Console.WriteLine("Geen idee");
          break;

      }
      #endregion
    }
  }
}
