using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerMenu playerMenu = new PlayerMenu();

            playerMenu["Ray Lewis"] = new Player("Ray Lewis", "52", Position.LB, Skin.Black, new Skill(90, 92, 99), 1.95m, 110m);
            playerMenu["Zach Thomas"] = new Player("Zach Thomas", "54", Position.LB, Skin.White, new Skill(92, 95, 93), 1.8m, 105m);
            playerMenu["Junior Seau"] = new Player("Junior Seau", "55", Position.LB, Skin.Black, new Skill(92, 91, 95), 1.98m, 109m);
            
            var patrickWillis = playerMenu["Ray Lewis"].Clone() as Player;
            patrickWillis.Name = "Patrick willis";

            var billRomanowsky = playerMenu["Zach Thomas"].Clone() as Player;
            billRomanowsky.Name = "Bill Romanowsky";

            Console.WriteLine($"Player {patrickWillis.Name}");
            Console.WriteLine($"Position:{patrickWillis.Skill.Power}");
            Console.WriteLine("---------------------");

            Console.WriteLine($"Player {billRomanowsky.Name}");
            Console.WriteLine($"Position:{billRomanowsky.Skill.Power}");
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }
    }
}
