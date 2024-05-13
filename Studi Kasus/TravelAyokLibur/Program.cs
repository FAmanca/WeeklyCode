using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string nama_pemesan,tujuan,member;
      int jumlah_tiket;
      float sub_total,total_bayar,diskon;
      float disc = 0f;
      float harga_tiket = 0f;

      Console.WriteLine("+===========================================+");
      Console.WriteLine("              TRAVEL AYOK LIBUR");
      Console.WriteLine("+===========================================+");
      Console.Write("Masukan Nama Pemesan : ");
      nama_pemesan = Console.ReadLine()?? "";
      tujuan:
      Console.Write("Masukan Tujuan : ");
      tujuan = Console.ReadLine() ?? "";
      if (tujuan.ToLower() != "cirebon" && tujuan.ToLower() != "surabaya" && tujuan.ToLower() != "malang")
      {
        Console.WriteLine("Input Tujuan Tidak Tersedia");
        goto tujuan;
      }
      jumlah:
      Console.Write("Masukan Jumlah Tiket : ");
      jumlah_tiket = int.Parse(Console.ReadLine()?? "");
      if (jumlah_tiket <1)
      {
        Console.WriteLine("Input Invalid");
        goto jumlah;
      }
      Console.Write("Apakah Anda Member ?? (y/n) : ");
      member = Console.ReadLine()?? "";
      if (member == "y")
      {
        disc = 0.1f; 
        switch (tujuan.ToLower())
        {
            case "malang":
              harga_tiket = 500000f;
              break;
            case "cirebon":
              harga_tiket = 150000f;
              break;
            case "surabaya":
              harga_tiket = 300000f;
              break;
            default:
              break;
        }
      }
      else
      {
        switch (tujuan.ToLower())
        {
          case "malang":
            harga_tiket = 500000f;
            break;
          case "cirebon":
            harga_tiket = 150000f;
            break;
          case "surabaya":
            harga_tiket = 300000f;
            break;
          default:
            break;
        }
      }
      void hitung ()
      {
        sub_total = harga_tiket * jumlah_tiket;
        diskon = sub_total * disc;
        total_bayar = sub_total - diskon;
        return;
      }
      void struk ()
      {
        Console.WriteLine("+===========================================+");
        Console.WriteLine("              TRAVEL AYOK LIBUR              ");
        Console.WriteLine("+===========================================+");
        Console.WriteLine($"Harga tiket : Rp.{harga_tiket}");
        Console.WriteLine($"Sub Total   : Rp.{sub_total}");
        Console.WriteLine($"Diskon      : Rp.{diskon}");
        Console.WriteLine($"Total Bayar : Rp.{total_bayar}");
        Console.WriteLine("+===========================================+");
      }
      hitung();
      struk();
    }
  }
}