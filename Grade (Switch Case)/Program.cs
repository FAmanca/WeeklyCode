using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int nilai;

          Console.WriteLine("Rentang Nilai");
          Console.Write("Masukan Nilai : ");
          nilai=int.Parse(Console.ReadLine() ?? "");

          switch (nilai)
          {
              case >=90 and <=100:
                
              default:
              break;
          }
        }
    }
}