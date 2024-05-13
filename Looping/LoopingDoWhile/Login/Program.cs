using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("FAKE LOGIN SYSTEM");
      string username = "admin";
      string password = "pwadmin123";
      string in_user, in_pw;
      do
      {
        Console.Write("Masukan Username : ");
        in_user = Console.ReadLine() ?? "";

        Console.Write("Masukan Password : ");
        in_pw = Console.ReadLine() ?? "";

      } while (in_user != username || in_pw != password);
      Console.WriteLine("LOGIN SUKSES");
    }
  }
}