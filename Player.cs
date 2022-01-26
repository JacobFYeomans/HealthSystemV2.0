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
            //takedamage testing
            DebugAssert(100, 100, 99);

            //taking damage & overflow 
            TakeDamage(101);
            DebugAssert(0, 99, 99);

            //losing lives
            TakeDamage(99);
            DebugAssert(100, 100, 98);

            //very large values
            TakeDamage(50000000);
            DebugAssert(100, 100, 97);
            TakeDamage(int.MaxValue);
            DebugAssert(100, 100, 96);

            //very small values
            TakeDamage(-50000000);
            DebugAssert(100, 100, 96);
            TakeDamage(int.MinValue);
            DebugAssert(100, 100, 96);

            //unusual values (EX: 0)
            TakeDamage(0);
            DebugAssert(100, 100, 96);

            //setting stats for shield regen testing
            shield = 50;
            health = 50;

            //regenerate shield testing
            RegenerateShield(10);
            DebugAssert(60, 50, 96);

            //values exceeding shield maximum
            RegenerateShield(70);
            DebugAssert(100, 50, 96);

            //very large values
            RegenerateShield(50000000);
            DebugAssert(100, 50, 96);
            RegenerateShield(int.MaxValue);
            DebugAssert(100, 50, 96);

            //very small values
            RegenerateShield(-50000000);
            DebugAssert(100, 50, 96);
            RegenerateShield(int.MinValue);
            DebugAssert(100, 50, 96);

            //unusual values (EX: 0)
            RegenerateShield(0);
            DebugAssert(100, 50, 96);

            //setting stats for heal testing
            shield = 50;
            health = 50;

            //heal testing
            Heal(10);
            DebugAssert(50, 60, 96);

            //values exceeding health maximum
            Heal(70);
            DebugAssert(50, 100, 96);

            //very large values
            Heal(50000000);
            DebugAssert(50, 100, 96);
            Heal(int.MaxValue);
            DebugAssert(50, 100, 96);

            //very small values
            Heal(-50000000);
            DebugAssert(50, 100, 96);
            Heal(int.MinValue);
            DebugAssert(50, 100, 96);

            //unusual values (EX: 0)
            Heal(0);
            DebugAssert(50, 100, 96);

        }
        private void DebugAssert(int shd, int hlt, int lvs)
        {
            Debug.Assert(shield == shd);
            Debug.Assert(health == hlt);
            Debug.Assert(lives == lvs);
        }
    }
}
