using System;
using System.Collections.Generic;

namespace IntroCsharp
{
  public class Collections
  {
    public static void CollectionsArray()
    {
      #region CollectionsArray
      var myArray = new string[10];
      Console.WriteLine(string.Join(",", myArray));

      myArray[1] = "abc";
      myArray[7] = "def";

      // myArray[12] = "123";
      Console.WriteLine(string.Join(",", myArray));
      #endregion
    }

    public static void CollectionsList()
    {
      #region CollectionsList
      var myList = new List<string>();
      Console.WriteLine(string.Join(",", myList));

      myList.Add("a");
      myList.Add("b");
      myList.Add("c");

      Console.WriteLine(string.Join(",", myList));
      #endregion
    }
  }
}
