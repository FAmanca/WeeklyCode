using System;

class Hewan
{
  public virtual void Suara()
  {
    Console.WriteLine("Hewan mengeluarkan suara");
  }
}

class Kucing : Hewan
{
  public override void Suara()
  {
    Console.WriteLine("Kucing mengeluarkan suara meong");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Hewan hewan = new Kucing();
    hewan.Suara();
  }
}