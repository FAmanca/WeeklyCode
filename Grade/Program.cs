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

          if (nilai>=90 && nilai <=100)
          {
            Console.WriteLine("Grade A");
          }

          else if (nilai>=80 && nilai <=89)
          {
            Console.WriteLine("Grade B");
          }

          else if (nilai>=70 && nilai <=79)
          {
            Console.WriteLine("Grade C");
          }

          else if (nilai >=60 && nilai <69)
          {
            Console.WriteLine("Grade D");
          }

          else if (nilai >=0 && nilai<=59)
          {
            Console.WriteLine("Grade E");
          }
          else
          {
            Console.WriteLine("Input tidak valid");
          }
        }
    }
}