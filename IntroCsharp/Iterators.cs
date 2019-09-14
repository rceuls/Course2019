using System;

namespace IntroCsharp
{
  public class Iterators
  {
    public static void IteratorsForeach()
    {
      #region IteratorsForeach
      var myArray = new string[] { "a", "b", "c" };
      foreach (var item in myArray)
      {
        Console.WriteLine($"{item}");
      }
      #endregion
    }

    public static void IteratorsDoWhile()
    {

      #region IteratorsDoWhile
      var x = 1;
      do
      {
        Console.WriteLine("hit 01");
        x++;
      } while (x == 0);


      var y = 1;
      while (y == 0)
      {
        Console.WriteLine("hit 02");
        y++;
      }
      #endregion
    }

  }
}
