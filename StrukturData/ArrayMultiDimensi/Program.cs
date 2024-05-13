using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[, ,] vegetables = { 
        {
          {"Potato", "Pumpkin", "Cabbage", "Broccoli", "Paprika"},
          {"Spinach", "Scallion", "Cucumber", "Carrot", "Tomato"},
          {"Basil", "Oregano", "Rosemary", "Parsley", "Thyme"}
        },

        {
          {"Mushroom", "Onion", "Chickpeas", "Chamomile", "Lemongrass"},
          {"Turnip", "Shallot", "Lettuce", "Artichoke", "Aubergine"},
          {"Pepper", "Parsnip", "Daikon", "Peas", "Yam"}
        },

        {
          {"Shallot", "Lettuce", "Bayam", "Peas", "pandan"},
          {"Chives", "Leek", "Rhubarb", "Celery", "Okra"},
          {"Cauliflower", "waluh", "kentang", "Alfalfaa","Kangkung"}
        }
      };
      
      Console.Write("Masukan indeks array pertama : ");
      int inp = int.Parse(Console.ReadLine()?? "");
      Console.Write("Masukan indeks array keuda : ");
      int inp2 = int.Parse(Console.ReadLine() ?? "");
      Console.Write("Masukan indeks array ketiga : ");
      int inp3 = int.Parse(Console.ReadLine() ?? "");

      Console.WriteLine("Value dari Array dengan indeks ["+inp+","+inp2+","+inp3+"] adalah : "+vegetables[inp,inp2,inp3]);
    }
  }
}