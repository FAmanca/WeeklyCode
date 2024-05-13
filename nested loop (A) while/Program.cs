using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Looping angka");
      int i,j;
      i = 0;
      while (i < 3)
      {
        j=1;
        while (j <=3)
        {
          Console.Write(j);
          j++;
        }
        Console.Write(" ");
        i++;
      }
      
    }
  }
}