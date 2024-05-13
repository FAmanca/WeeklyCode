using System;

class Mahasiswa
{
  private string nama;

  public string GetNama()
  {
    return nama;
  }

  public void SetNama(string nama)
  {
    this.nama = nama;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Mahasiswa mahasiswa = new Mahasiswa();
    mahasiswa.SetNama("Supri");
    Console.WriteLine("Nama mahasiswa: " + mahasiswa.GetNama());
  }
}
