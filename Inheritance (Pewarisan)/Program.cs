using System;

class Kendaraan
{
  public void Start()
  {
    Console.WriteLine("Kendaraan dinyalakan.");
  }
}

class Mobil : Kendaraan
{
  public void Drive()
  {
    Console.WriteLine("Mobil bergerak.");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Mobil myCar = new Mobil();
    myCar.Start();
    myCar.Drive();
  }
}
