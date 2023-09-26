using System;

namespace FinalHud
{
    internal class Program
    {
        private static int Health = 100;
        private static int Shield = 50;
        private static int Lives = 1;
        private static float ScoreMultiplier = 0f;
        private static int Weapon = 0;
        private static string[] WeaponNames = { "Pistol", "Shotgun", "Spreader", "Laser", "Sniper", "BFG" };

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CAVE ESCAPE");
            Console.WriteLine("----------------------");

            ShowHUD();

            Console.WriteLine("------------");
            Console.WriteLine("START GAME");
            Console.WriteLine("");

            Console.WriteLine("You Awaken in a dark cave, cold and damp. Torch in hand, you begin your perilous journey back to the surface.");

            Console.WriteLine("As you enter a new part of the cave, you come across a goblin with an old rusty sword");
            Console.WriteLine("");
            Console.WriteLine("It Attacks You!");

            TakeDamage(30);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("You do a counter-attack and kill the goblin!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            AddScore(15, 0.5f);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("You come across an underwater waterfall inside the cave. You see a Giant bat emerge from behind the waterfall!");
            Console.WriteLine("It spits mutated acid at you!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            TakeDamage(50);

            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("The bat flies away before you can attack it!");
            Console.WriteLine("");
            Console.WriteLine("After a long journey to the surface, you begin to see the light from the sun on the cold cave rocks.");
            Console.WriteLine("Just before you reach the exit, a huge troll blocks your path. It roars and swings its massive club right on top of you, ending your journey!");
            Console.WriteLine("");
            Console.WriteLine("------------");

            TakeDamage(100);

            Console.WriteLine("------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ResetColor();

            Console.ReadKey(true);
        }

        private static void ShowHUD()
        {
            Console.WriteLine("Player Stats");
            Console.WriteLine("------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HP: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Weapon: " + WeaponNames[Weapon]);
            Console.WriteLine("Score Multiplier: " + ScoreMultiplier);
            Console.ResetColor();
            Console.WriteLine("Health Status: " + GetHealthStatus());
        }
        private static void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                Lives--; 
                ScoreMultiplier = 0; 
            }

            ShowHUD();
        }

        private static string GetHealthStatus()
        {
            if (Health <= 10)
                return "Imminent Danger";
            else if (Health <= 50)
                return "Badly Hurt";
            else if (Health <= 75)
                return "Hurt";
            else if (Health < 100)
                return "Healthy";
            else
                return "Perfect Health";
        }

        private static void AddScore(int pointsearned, float scoremultiplier)
        {
            ScoreMultiplier += pointsearned * scoremultiplier;
            ShowHUD();
        }
    }
}
