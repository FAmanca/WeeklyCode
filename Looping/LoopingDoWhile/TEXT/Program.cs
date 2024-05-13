using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      string text = "UNITYENGINE";
      int i = 1;

      do
      {
        Console.WriteLine(i+"."+text);
        i++;
      } while (i<=15);
    }
  }
}