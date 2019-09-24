#region OO4
using System;
using System.Collections.Generic;

namespace OOCsharp
{
  public class Polymorphism
  {
    public static void RunStuff(string[] args)
    {
      var dogs = new List<Dog> {
        new Dog(), new Dog(), new Dog()
      };
      var cats = new List<Cat> {
        new Cat(), new Cat(), new Cat(),
      };

      var animals = new List<Animal>();
      animals.AddRange(cats);
      animals.AddRange(dogs);

      Console.WriteLine("-------");
      Console.WriteLine("Animals");
      Console.WriteLine("-------");
      animals.ForEach(MySubMethod);

      Console.WriteLine("-------");
      Console.WriteLine("Dogs");
      Console.WriteLine("-------");
      dogs.ForEach(MySubMethod);

      Console.WriteLine("-------");
      Console.WriteLine("Cats");

      Console.WriteLine("-------");
      cats.ForEach(MySubMethod);
    }

    private static void MySubMethod(Animal animal)
    {
      Console.WriteLine(animal.GetNoise());
    }
  }

  public abstract class Animal
  {
    public abstract string GetNoise();
  }

  public class Dog : Animal
  {
    public override string GetNoise()
    {
      return "Woef";
    }
  }

  public class Cat : Animal
  {
    public override string GetNoise()
    {
      return "Miauw";
    }
  }
}
#endregion