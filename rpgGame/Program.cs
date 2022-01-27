using rpgGame.src.Entities;
using System;


    class Program
{
    static void Main()
    {
        Warrrior Arous = new Warrrior("Arous",1,"warrior",300,50);
        Warrrior Saitama = new Warrrior("Saitama", 1, "Devil",300,40);
        Wizzard Jenica = new Wizzard("Jenica", 11, "wizzard",150,400);
        Druid Popis = new Druid("PoPIS", 11, "Druid white",80,600);

        Console.WriteLine(Arous);
        Console.WriteLine(Saitama);
        Console.WriteLine(Jenica);
        Console.WriteLine(Popis);
  
        Console.WriteLine(Saitama.AtackHero(33));
        Console.WriteLine(Jenica.AtackHero(2));
        Console.WriteLine(Popis.AtackHero(2));
        Console.WriteLine(Popis.AtackHero(6));
       
    }
}