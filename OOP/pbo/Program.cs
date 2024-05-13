using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  class Hero 
  {
    public String nama;
    public int health;

    public Hero(String nama, int health) {
      this.nama = nama;
      this.health = health;
    }

    public void GetDamage() {
      this.health -= 20;
    }

    public void ShowInfo() {
      Console.WriteLine("nama : "+this.nama);
      Console.WriteLine("health : "+this.health);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Masukan nama hero : ");
      string isinama = Console.ReadLine()?? "";

      Console.Write("Masukan darah : ");
      int darah = int.Parse(Console.ReadLine() ?? "");
      Hero hero1 = new Hero(isinama, darah);
      Console.WriteLine(hero1.nama); 
      Console.WriteLine(hero1.health); 
    }
  }
}