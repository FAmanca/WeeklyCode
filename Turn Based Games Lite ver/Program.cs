using System;
using System.Diagnostics;

namespace Turn_Based_Games_Lite_ver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int player_hp = 100;
            int enemy_hp = 100;

            int ak47_damage = rnd.Next(15, 22);
            int m1014_damage = rnd.Next(17, 25);
            int rpg_damage = 999;

            int e_m4a1_damage = rnd.Next(17, 21);
            int e_grenade_damage = rnd.Next(20, 25);

            Console.WriteLine("Turn Based Shooting games lite ver");
            while (player_hp > 0 && enemy_hp > 0)
            {
                Console.WriteLine("Your hp : " + player_hp + " Enemy hp : " + enemy_hp);
                Console.WriteLine("Your Turn");
                Console.Write("Choose your weapon (ak47/m1014) :");
                string weapon = Console.ReadLine() ?? "";

                int damage1 = 0;
                int damage2 = 0;

                if (weapon == "ak47")
                {
                    Console.WriteLine("Choosing ak47");
                    Console.WriteLine("bbbbrtrtttt");
                    damage1 = ak47_damage;
                    System.Threading.Thread.Sleep(1500);
                }
                else if (weapon == "m1014")
                {
                    Console.WriteLine("Choosing m1014");
                    Console.WriteLine("bbrtdaghhh");
                    damage1 = m1014_damage;
                    System.Threading.Thread.Sleep(1500);
                }
                
                else if (weapon== "rpg")
                {   
                    Console.WriteLine("Choosing RPG");
                    Console.WriteLine("shuuuduaarrr");
                    damage1 = rpg_damage;
                    System.Threading.Thread.Sleep(1500);
                }
                
                else if (weapon=="MAXIMUM")
                {
                    Console.WriteLine("increase health actived");
                    player_hp=(player_hp+999999999);
                }

                enemy_hp -= damage1;
                Console.WriteLine("Total damage: " + damage1);
                System.Threading.Thread.Sleep(1500);

                Console.WriteLine("Enemy turn");
                int wpenemy = rnd.Next(1, 9);
                System.Threading.Thread.Sleep(1000);

                if (wpenemy < 5)
                {
                    Console.WriteLine("Enemy Choosing m4a1");
                    Console.WriteLine("bbbrtrtrtr");
                    damage2 = e_m4a1_damage;
                    System.Threading.Thread.Sleep(1500);
                }
                else if (wpenemy >= 7)
                {
                    Console.WriteLine("Enemy Choosing Grenade");
                    Console.WriteLine("bduabrarrr");
                    damage2 = e_grenade_damage;
                    System.Threading.Thread.Sleep(1500);
                }

                player_hp -= damage2;
                Console.WriteLine("Total damage: " + damage2);
                System.Threading.Thread.Sleep(1500);
            }

            if (player_hp <= 0)
            {
                Console.WriteLine("You Died");
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("Enemy died");
                Console.WriteLine("You Win");
            }
        }
    }
}

