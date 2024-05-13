using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[,] fruits = {
        { "Apel", "Mangga", "Alpukat", "Cherry", "Strawberry" },
        {"Peach", "Plum", "Papaya", "Raspberry", "Banana"}
        };
      
      //! Menampilakan peach
      Console.WriteLine(fruits[1,0]);

      //!Menampilkan Semua 
      foreach (var fruit in fruits)
      {
        Console.WriteLine(fruit);
      }
    }
  }
}