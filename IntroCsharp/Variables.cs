// This is a namespace; a user defined logical grouping of classes.
using System;

namespace IntroCsharp
{
  public class Variables
  {
    public static void VariableUsage()
    {
      #region VariableUsage
      var myName = "Raf";
      string myCatsName = "Loki";
      // var myDogsName = null;

      Console.WriteLine($"My name is {myName} and my cat's name is {myCatsName}.");
      #endregion
    }
  }
}
