using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string [,] sayuran = {{"Potato", "Pumpkin", "Cabbage", "Broccoli", "Carrot", "Tomato"}, {"Wasabi", "Ginger", "Coriander", "Fennel", "Jalapeno", "Peanuts"}};

      Console.WriteLine(sayuran[0,1]);

      foreach (var sayur in sayuran)
      {
        Console.WriteLine(sayur);
      }
    }
  }
}

