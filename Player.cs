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

        public static void TakeDamage(int dmg)
        {
            
        }
        public static void Heal(int heal)
        {

        }
        public static void ShowStats()
        {

        }
        public static void RegenerateShield(int rgn)
        {

        }
        public Player()
        {
            Console.WriteLine("Player class has been instantiated");
        }
    }
}
