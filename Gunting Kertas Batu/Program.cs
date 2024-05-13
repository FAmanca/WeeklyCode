using System;

namespace GamesGTB
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random rnd= new Random();

          int playerscore=0;
          int enemyscore=0;

          Console.WriteLine("GAME Gunting Kertas Batu");
          while (playerscore !=3 && enemyscore !=3)
          {
            Console.WriteLine("Skor Kamu : "+playerscore+ " Skor Musuh : "+enemyscore);
            Console.WriteLine("Ketik G untuk memilih Gunting, K untuk Kertas, B untuk Batu");
            string player = Console.ReadLine() ?? "";
            
            int enemy = rnd.Next(1, 3);
            if (enemy == 1)
            {
              Console.WriteLine("Musuh Memilih Batu");
              switch (player)
              {
                  case "g":
                    Console.WriteLine("Kamu Kalah");
                    enemyscore++;
                    break;
                  case "b":
                    Console.WriteLine("Seri");
                    break;
                  default:
                    Console.WriteLine("Kamu Menang");
                    playerscore++;
                    break;
              }
            }

            else if (enemy == 2)
            {
              Console.WriteLine("Musuh Memilih Gunting");
              switch (player)
              {
                  case "g":
                    Console.WriteLine("Seri");
                    break;
                  case "b":
                    Console.WriteLine("Kamu Menang");
                    playerscore++;
                    break;
                  default:
                    Console.WriteLine("Kamu Kalah");
                    enemyscore++;
                    break;
              }
            }

            else
            {
              Console.WriteLine("Musuh Memilih Kertas");
              switch (player)
              {
                  case "g":
                    Console.WriteLine("Kamu Menang");
                    playerscore++; 
                    break;
                  case "b":
                    Console.WriteLine("Kamu Kalah");
                    enemyscore++;
                    break;
                  default:
                    Console.WriteLine("Seri");
                    break;
              }
            }
          }

          if (playerscore==3)
          {
            Console.WriteLine("KAMU MEMNANGKAN GAME INI !");
          }
          else
          {
            Console.WriteLine("KAMU KALAH !");
          }
        }
    }
}