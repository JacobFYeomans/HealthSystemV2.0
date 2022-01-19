using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class Player
    {
        public int health = 100;
        public int lives = 3;
        public int shield = 100;

        private const int maxHealth = 100;
        private const int maxShield = 100;

        public static void TakeDamage(int dmg, int health, int shield)
        {
            if (shield == 0)
            {
                health = health - dmg;
                Console.WriteLine("Player has taken " + dmg + " damage.");
            }
            if (shield > 0)
            {
                shield = shield - dmg;
                if (shield < 0)
                {
                    health = health + shield;
                    Console.WriteLine("Player has taken " + -shield + " damage through their shield.");
                    shield = 0;
                }
            }
        }
        public static void Heal(int heal, int health)
        {
            if (health < 100 && health > 0)
            {
                health = health + heal;
                Console.WriteLine("Health has regenerated " + heal + " hitpoints");
            }
            else
            {
                Console.WriteLine("Health is full is full.");
            }
        }
        public static void ShowStats()
        {

        }
        public static void RegenerateShield(int rgn, int shield)
        {
            if (shield < 100)
            {
                shield = shield + rgn;
                Console.WriteLine("Shield has regenerated " + rgn + " hitpoints");
            }
            else
            {
                Console.WriteLine("Shield is full.");
            }
        }
        public Player()
        {
            Console.WriteLine("Player class has been instantiated");
        }
    }
}
