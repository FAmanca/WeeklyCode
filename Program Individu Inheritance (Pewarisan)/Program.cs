using System;

class Player
{
  public void Darah()
  {
    int darah = 100;
    Console.WriteLine($"Darah player : {darah}");
  }
}

class PlayerWaepon : Player
{
  public void senjata()
  {
    string senjata = "M13B";
    int damage = 20;
    Console.WriteLine($"Senjata yang dipakai {senjata}");
    return;
  }
  public void amunisi()
  {
    int amunisi = 30;
    Console.WriteLine($"Amnunisi yang tersisa {amunisi}");
  }
}

class PlayerLethal : PlayerWaepon
{
  public void Lethal()
  {
    string lethal = "Grenade";
    int damage = 30;
    Console.WriteLine($"Lethal yang dipakai {lethal}");
  }
}

class Enemy
{
  public void Darah()
  {
    int darah = 100;
    Console.WriteLine($"Darah musuh : {darah}");
  }
}
class EnemyWaepon
{
  public void senjata()
  {
    string senjata = "ak47";
    int damage = 15;
    Console.WriteLine($"Senjata yang dipakai {senjata}");
    return;
  }
  public void amunisi()
  {
    int amunisi = 24;
    Console.WriteLine($"Amnunisi yang tersisa {amunisi}");
  }
}

class Program
{

  static void DisplayPlayerStat()
  {
    Console.WriteLine("Menampilkan stat player");
    Player pemain = new Player();
    pemain.Darah();
    PlayerWaepon karakter = new PlayerWaepon();
    karakter.senjata();
    karakter.amunisi();
    Console.WriteLine();
  }

  static void DisplayEnemyStat()
  {
    Console.WriteLine("Menampilkan stat musuh");
    Enemy musuh = new Enemy();
    musuh.Darah();
    EnemyWaepon karaktermusuh = new EnemyWaepon();
    karaktermusuh.senjata();
    karaktermusuh.amunisi();
    Console.WriteLine();
  }

  static void Main(string[] args)
  {
    DisplayPlayerStat();
    DisplayEnemyStat();
  }
}
