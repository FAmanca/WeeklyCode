namespace Player
{
  internal class Player 
  {
    public string Name { get; private set; }
    public float Darah { get; private set; }
    public int Attack { get; private set; }
    public float Defense { get; private set; }
    public float NormalAttack { get; private set; }
    public float SkillAttack { get; private set; }

    public Player (string name, float hp, int atk, float def, float na, float skill)
    {
      Name = name;
      Darah = hp ;
      Attack = atk;
      Defense = def;
      NormalAttack = na;
      SkillAttack = skill;
    }

    public void Serang(Player lawan)
    {
      Console.WriteLine($"{Name} memilih skill:");
      Console.WriteLine("1. NormalAttack)");
      Console.WriteLine("2. Skill");

      // Menerima input dari pengguna untuk memilih skill
      int pilihanSkill = int.Parse(Console.ReadLine() ?? "");

      // Panggil metode menerima serangan dengan damage sesuai skill yang dipilih
      if (pilihanSkill == 1)
      {
        Console.WriteLine($"{Name} menyerang {lawan.Name} Normal Attack");
        lawan.menerimaSerangan(NormalAttack);
      }
      else if (pilihanSkill == 2)
      {
        Console.WriteLine($"{Name} menyerang {lawan.Name} dengan Skill");
        lawan.menerimaSerangan(SkillAttack);
      }
    }

    public void menerimaSerangan(float Kerusakan)
    {
      float ReduceDMG;
      ReduceDMG = Defense / (Defense + 300) * Kerusakan;
      Darah = Darah - Kerusakan - ReduceDMG;
      Console.WriteLine($"{Name} menerima {Kerusakan} kerusakan!");
      Console.WriteLine($"sisa HP {Name} Adalah {Darah}");
      Console.WriteLine("-----------------------------------");

      if (Darah <= 0)
      {
        Console.WriteLine($"{Name} telah Kalah(SKILL ISSUE LUWH) ");
      }
    }
  }
}