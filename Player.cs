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
        protected int maxValue = 2147483647;
        protected int minValue = -2147483648;

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
            TakeDamage(101);
            Debug.Assert(shield == 0);
            Debug.Assert(health == 99);
            Debug.Assert(lives == 99);
            TakeDamage(99);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 98);
            TakeDamage(30000000);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 97);
            TakeDamage(-300000000);
            Debug.Assert(health == 100);
            Debug.Assert(shield == 100);
            Debug.Assert(lives == 97);
            shield = 50;
            health = 50;
            RegenerateShield(10);
            Debug.Assert(shield == 60);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 97);
            RegenerateShield(50000000);
            Debug.Assert(shield == 100);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 97);
            RegenerateShield(-50000000);
            Debug.Assert(shield == 100);
            Debug.Assert(health == 50);
            Debug.Assert(lives == 97);
            shield = 50;
            health = 50;
            Heal(10);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 60);
            Debug.Assert(lives == 97);
            Heal(50000000);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 97);
            Heal(-50000000);
            Debug.Assert(shield == 50);
            Debug.Assert(health == 100);
            Debug.Assert(lives == 97);
        }
        private void DebugAssert(int shd, int hlt, int lvs)
        {
            Debug.Assert(shield == shd);
            Debug.Assert(health == hlt);
            Debug.Assert(lives == lvs);
        }
    }
}
