using System;

namespace ProgramPembelian // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string pilihan, Tgl_beli, Nama_Pembeli = "", Nama_Barang = "", Jenis_Barang = "";
      int Harga_Barang = 0, Jumlah_Barang = 0, Total_Pembayaran = 0, uangBayar, Kembali;
      bool ValidasiNo1 = false;
      Tgl_beli = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
      while (true)
      {
        Console.WriteLine("Pilihan");
        Console.WriteLine("1. Pembelian");
        Console.WriteLine("2. Pembayaran");
        Console.WriteLine("3. Close");
        Console.Write("Masukan Pilihan : ");
        pilihan = Console.ReadLine() ?? "";

        if (pilihan == "1") {
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
          ValidasiNo1 = true;
        }

        else if (pilihan == "2") {
          if (!ValidasiNo1) {
            Console.WriteLine("HARAP LENGKAPI PEMBELIAN");
          }
          else {
            Console.WriteLine($"Tgl_beli : {Tgl_beli}");
            Console.WriteLine($"Nama Pembeli : {Nama_Pembeli}");
            Console.WriteLine($"Nama Barang Yang Dibeli : {Nama_Barang}");
            Console.WriteLine($"Jenis Barang : {Jenis_Barang}");
            Console.WriteLine($"Harga Barang : {Harga_Barang}");
            Console.WriteLine($"Jumlah Barang : {Jumlah_Barang}");
            Console.WriteLine($"Total Pembayaran : Rp.{Total_Pembayaran}");
            Console.Write("Uang Yang Dibayarkan : ");
            uangBayar = int.Parse(Console.ReadLine()?? "");
            Kembali = uangBayar - Total_Pembayaran;

            Console.WriteLine("+========================================+");
            Console.WriteLine("              TOKO SERBA ADA");
            Console.WriteLine("          Isekai, AxelCity NO 69");
            Console.WriteLine("+========================================+");
            Console.WriteLine($"Tanggal Pembelian : {Tgl_beli}");
            Console.WriteLine($"Nama Pembeli      : {Nama_Pembeli}");
            Console.WriteLine("+========================================+");
            Console.WriteLine($"Nama Barang       : {Nama_Barang}");
            Console.WriteLine($"Jenis Barang      : {Jenis_Barang}");
            Console.WriteLine($"Harga Barang      : Rp.{Harga_Barang}");
            Console.WriteLine($"Jumlah Barang     : {Jumlah_Barang}");
            Console.WriteLine("+========================================+");
            Console.WriteLine($"Total Pembayaran  : Rp.{Total_Pembayaran}");
            Console.WriteLine($"Uang Dibayar      : Rp.{uangBayar}");
            Console.WriteLine($"Kembalian         : Rp.{Kembali}");
            Console.WriteLine("+========================================+");
            break;
          }
        }
        else {
          break;
        }
      }
    }
  }
}