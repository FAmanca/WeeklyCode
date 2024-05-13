using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float celsius,f;
      Console.WriteLine("Program menggunakan function");
      Console.WriteLine("mengkonversi Celsius Ke Farenheit");
      Console.Write("Masukan Celcius : ");
      celsius = float.Parse(Console.ReadLine() ?? "");

      f=Farenheit(celsius);
      Console.WriteLine($"Hasil Konversi adalah {f} F");
    }
    static float Farenheit(float celsius)
    {
      return (1.8f*celsius)+32;
    }
  }
}