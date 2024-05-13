using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[] fruits = {"Apel", "Mangga", "Alpukat", "Cherry", "Strawberry"};

      //! Menampilakan mangga
      Console.WriteLine(fruits[1]);

      foreach (var fruit in fruits)
      {
        Console.WriteLine(fruit);
      }
    }
  }
}