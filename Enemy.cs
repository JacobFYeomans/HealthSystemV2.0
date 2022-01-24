using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV2._0
{
    class Enemy : GameCharacter
    {
        public Enemy(string name)
        {
            Console.WriteLine("Enemy class has been instantiated");
            Console.WriteLine("");

            this.name = name;

            lives = maxLives;
            health = maxHealth;
            shield = maxShield;

            Console.WriteLine();
        }
        public void UnitTest()
        {
            Enemy enemy = new Enemy("EnemyUnitTesting");
            enemy.TakeDamage(101);
            Debug.Assert(enemy.shield == 0);
            Debug.Assert(enemy.health == 99);
            Debug.Assert(enemy.lives == 99);
            enemy.TakeDamage(99);
            Debug.Assert(enemy.health == 100);
            Debug.Assert(enemy.shield == 100);
            Debug.Assert(enemy.lives == 98);
            enemy.TakeDamage(300);
            Debug.Assert(enemy.health == 100);
            Debug.Assert(enemy.shield == 100);
            Debug.Assert(enemy.lives == 97);
            enemy.TakeDamage(-300);
            Debug.Assert(enemy.health == 100);
            Debug.Assert(enemy.shield == 100);
            Debug.Assert(enemy.lives == 97);
            enemy.shield = 50;
            enemy.health = 50;
            enemy.RegenerateShield(10);
            Debug.Assert(enemy.shield == 60);
            Debug.Assert(enemy.health == 50);
            Debug.Assert(enemy.lives == 97);
            enemy.RegenerateShield(500);
            Debug.Assert(enemy.shield == 100);
            Debug.Assert(enemy.health == 50);
            Debug.Assert(enemy.lives == 97);
            enemy.RegenerateShield(-500);
            Debug.Assert(enemy.shield == 100);
            Debug.Assert(enemy.health == 50);
            Debug.Assert(enemy.lives == 97);
            enemy.shield = 50;
            enemy.health = 50;
            enemy.Heal(10);
            Debug.Assert(enemy.shield == 50);
            Debug.Assert(enemy.health == 60);
            Debug.Assert(enemy.lives == 97);
            enemy.Heal(500);
            Debug.Assert(enemy.shield == 50);
            Debug.Assert(enemy.health == 100);
            Debug.Assert(enemy.lives == 97);
            enemy.Heal(-500);
            Debug.Assert(enemy.shield == 50);
            Debug.Assert(enemy.health == 100);
            Debug.Assert(enemy.lives == 97);
        }
    }
}
