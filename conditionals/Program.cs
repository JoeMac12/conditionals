using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    internal class Program
    {
        static int health;
        static int lives;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------");
            Console.WriteLine("");

            // initializations
            health = 100;
            lives = 1;

            // sample gameplay

            ShowHud();
            TakeDamage(10);
            Console.WriteLine("");
            ShowHud();
            TakeDamage(40);
            Console.WriteLine("");
            ShowHud();
            TakeDamage(60);
            Console.WriteLine("");
            ShowHud();


            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
        }

        static void ShowHud()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;

            if (health <= 0)
            {
                Console.WriteLine("GAMEOVER");
                lives = lives - 1;

                if (lives <= 0)
                {
                    Console.WriteLine("Player has DIED");
                }

                health = 0;
            }
        }
    }
}
