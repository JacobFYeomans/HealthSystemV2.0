using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV2._0
{
    class Player : GameCharacter
    {
        public Player(string name)
        {
            Console.WriteLine("Player class has been instantiated");
            Console.WriteLine("");

            this.name = name;

            lives = maxLives;
            health = maxHealth;
            shield = maxShield;

            Console.WriteLine();
        }
        public void UnitTest()
        {
            Player player = new Player("PlayerUnitTesting");
            player.TakeDamage(101);
            Debug.Assert(player.shield == 0);
            Debug.Assert(player.health == 99);
            Debug.Assert(player.lives == 99);
            player.TakeDamage(99);
            Debug.Assert(player.health == 100);
            Debug.Assert(player.shield == 100);
            Debug.Assert(player.lives == 98);
            player.TakeDamage(300);
            Debug.Assert(player.health == 100);
            Debug.Assert(player.shield == 100);
            Debug.Assert(player.lives == 97);
            player.TakeDamage(-300);
            Debug.Assert(player.health == 100);
            Debug.Assert(player.shield == 100);
            Debug.Assert(player.lives == 97);
            player.shield = 50;
            player.health = 50;
            player.RegenerateShield(10);
            Debug.Assert(player.shield == 60);
            Debug.Assert(player.health == 50);
            Debug.Assert(player.lives == 97);
            player.RegenerateShield(500);
            Debug.Assert(player.shield == 100);
            Debug.Assert(player.health == 50);
            Debug.Assert(player.lives == 97);
            player.RegenerateShield(-500);
            Debug.Assert(player.shield == 100);
            Debug.Assert(player.health == 50);
            Debug.Assert(player.lives == 97);
            player.shield = 50;
            player.health = 50;
            player.Heal(10);
            Debug.Assert(player.shield == 50);
            Debug.Assert(player.health == 60);
            Debug.Assert(player.lives == 97);
            player.Heal(500);
            Debug.Assert(player.shield == 50);
            Debug.Assert(player.health == 100);
            Debug.Assert(player.lives == 97);
            player.Heal(-500);
            Debug.Assert(player.shield == 50);
            Debug.Assert(player.health == 100);
            Debug.Assert(player.lives == 97);
        }
        private void DebugAssert(int shd, int hlt, int lvs) //could use this maybe?
        {
        //    Debug.Assert(player.shield == shd);
        //    Debug.Assert(player.health == hlt);
        //    Debug.Assert(player.lives == lvs);
        }
    }
}
