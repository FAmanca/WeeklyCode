using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Looping angka 12345");
      int i;
      i=1;
      
      do
      {
        Console.Write(i);
        i++;
      } while (i<6);
    }
  }
}
