using System;

namespace ProgramPembelian // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        string pilihan;
        Console.WriteLine("Pilihan");
        Console.WriteLine("1. Pembelian");
        Console.WriteLine("2. Close");
        Console.Write("Masukan Pilihan : ");
        pilihan = Console.ReadLine() ?? "";

        if (pilihan == "1") {
          string Tgl_beli, Nama_Pembeli, Nama_Barang, Jenis_Barang;
          int Harga_Barang, Jumlah_Barang, Total_Pembayaran ;
          
          Tgl_beli = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
          Console.WriteLine($"Tgl_beli : {Tgl_beli}");

          Console.Write("Nama Pembeli : ");
          Nama_Pembeli = Console.ReadLine() ?? "";

          Console.Write("Nama Barang Yang Dibeli : ");
          Nama_Barang = Console.ReadLine() ?? "";

          Console.Write("Jenis Barang : ");
          Jenis_Barang = Console.ReadLine() ?? "";

          Console.Write("Harga Barang : ");
          Harga_Barang = int.Parse(Console.ReadLine() ?? "");

          Console.Write("Jumlah Barang : ");
          Jumlah_Barang = int.Parse(Console.ReadLine() ?? "");

          Total_Pembayaran = Harga_Barang * Jumlah_Barang;
          Console.WriteLine($"Total Pembayaran : Rp.{Total_Pembayaran}");
        }

        else if (pilihan == "2") {
          break;
        }
      }
    }
  }
}