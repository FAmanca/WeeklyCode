namespace pemain
{

  internal class program
  {
    static void Main(string[] args)
    {

      //Membuat Objek Pemain
      pemain mage = new pemain("Hutao", 100, 10, 25);
      pemain marksman = new pemain("Albedo", 100, 10, 25);

      //Mulai Permainan
      Console.WriteLine("Permainan Dimulai");
      Console.WriteLine("===================================");
      Console.WriteLine();

      //proses
      while (mage.Nyawa > 0 && marksman.Nyawa > 0)
      {
        mage.Serang(marksman);
        if (mage.Nyawa <= 0)
          break;
        if (marksman.Nyawa <= 0)
          break;
        marksman.Serang(mage);
      }

      //Permainan berakhir
      Console.WriteLine();
      Console.WriteLine("===================================");
      Console.WriteLine("Permainan selesai");
    }
  }
}