namespace pemain
{
  internal class pemain
  {
    //Atribut atau Properti
    public string Nama { get; private set; }
    public int Nyawa { get; private set; }
    public int Skill1 { get; private set; }
    public int Skill2 { get; private set; }

    public pemain(string nama, int nyawa, int skill1, int skill2)
    {
      Nama = nama;
      Nyawa = nyawa;
      Skill1 = skill1;
      Skill2 = skill2;
    }

    // Metode untuk menyerang dengan pilihan skill
    public void Serang(pemain lawan)
    {
      Console.WriteLine($"{Nama} memilih skill:");
      Console.WriteLine("1. Skill 1 (True Damage 10 crit 5)");
      Console.WriteLine("2. Skill 2 (Damage 25)");

      // Menerima input dari pengguna untuk memilih skill
      int pilihanSkill = int.Parse(Console.ReadLine() ?? "");

      // Panggil metode menerima serangan dengan damage sesuai skill yang dipilih
      if (pilihanSkill == 1)
      {
        Console.WriteLine($"{Nama} menyerang {lawan.Nama} dengan Skill 1");
        lawan.menerimaSerangan(Skill1);
      }
      else if (pilihanSkill == 2)
      {
        Console.WriteLine($"{Nama} menyerang {lawan.Nama} dengan Skill 2");
        lawan.menerimaSerangan(Skill2);
      }
      else
      {
        Console.WriteLine("Pilihan skill tidak valid!");
      }
    }

    // Metode menerima serangan
    public void menerimaSerangan(int Kerusakan)
    {
      Nyawa -= Kerusakan;
      Console.WriteLine($"{Nama} menerima {Kerusakan} kerusakan!");
      Console.WriteLine($"sisa HP {Nama} Adalah {Nyawa}");
      Console.WriteLine("-----------------------------------");

      if (Nyawa <= 0)
      {
        Console.WriteLine($"{Nama} telah Kalah(SKILL ISSUE LUWH) ");
      }
    }
  }
}