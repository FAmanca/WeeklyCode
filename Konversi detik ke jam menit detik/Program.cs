using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int detik, jam, menit;

          Console.Write("Masukan jumlah detik : ");
          detik=int.Parse(Console.ReadLine() ?? "");

          jam=(detik/3600);
          detik=(detik-(3600*jam));
          menit=(detik/60);
          detik=(detik-(60*menit));

          Console.WriteLine("maka konversinya adalah :"+jam+" jam "+menit+" menit "+detik+" detik");
        }
    }
}
