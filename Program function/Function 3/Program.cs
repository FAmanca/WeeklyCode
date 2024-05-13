using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float r,t,vol;
      
      Console.WriteLine("menghitung volume tabung");
      Console.Write("masukan jari jari : ");
      r = float.Parse(Console.ReadLine()?? "");
      Console.Write("masukan tinggi : ");
      t = float.Parse(Console.ReadLine()?? "");

      vol = volume(r, t);
      Console.WriteLine($"volume tabung adalah {vol} cm3");
    }
    static float volume(float r, float t)
    {
      float PHI = 3.14f;
      return PHI*(r*r)*t;
    } 
  }
}