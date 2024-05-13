namespace Player
{

  internal class Program
  {
    static void Main(string[] args)
    {
      //! USER STATS
      string PlayerName = "Diablo";
      float PlayerHP = 40000f;
      float PlayerDEF = 735;
      int PlayerATK = 2300;
      float NA = 0.7f * PlayerATK;
      float skill = 1.8f * PlayerATK; 
      //! USER STATS

      //! ENEMY STATS
      string EnemyName = "Makoto";
      float EnemyHP = 40000f;
      float EnemyDEF = 786;
      int EnemyATK = 2333;
      float EnemyNA = 0.7f * EnemyATK;
      float EnemySkill = 1.7f * EnemyATK;
      //! ENEMY STATS

      // Membuat Objek PlayerStats Dan enemy Stats
      Player user = new Player(PlayerName,PlayerHP, PlayerATK, PlayerDEF, NA, skill);
      Player enemy = new Player(EnemyName, EnemyHP, EnemyATK, EnemyDEF, EnemyNA, EnemySkill);

      //proses
      while (user.Darah > 0 && enemy.Darah > 0)
      {
        user.Serang(enemy);
        if (user.Darah <= 0)
          break;
        if (enemy.Darah <= 0)
          break;
        enemy.Serang(user);
      }

      //Permainan berakhir
      Console.WriteLine();
      Console.WriteLine("===================================");
      Console.WriteLine("Permainan selesai");
    }
  }
}   