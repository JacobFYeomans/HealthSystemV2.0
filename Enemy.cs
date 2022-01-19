using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class Enemy
    {
        private string name;
        public int health = 100;
        public int lives = 99;
        public int shield = 100;

        private const int maxLives = 99;
        private const int maxHealth = 100;
        private const int maxShield = 100;
        private const int minHealth = 0;
        private const int minShield = 0;
        private const int minLives = 0;

        public Enemy()
        {
            Console.WriteLine("Enemy class has been instantiated");
            Console.WriteLine("");

            lives = maxLives;
            health = maxHealth;
            shield = maxShield;

            Console.WriteLine();
        }
        public void RangeChecking()
        {
            if (health > maxHealth)
            {
                health = maxHealth;
            }
            if (health < minHealth)
            {
                health = minHealth;
            }
            if (shield > maxShield)
            {
                shield = maxShield;
            }
            if (shield < minShield)
            {
                shield = minShield;
            }
            if (lives > maxLives)
            {
                lives = maxLives;
            }
            if (lives < minLives)
            {
                lives = minLives;
            }

        }
        public void TakeDamage(int dmg)
        {
            int livesBefore = lives;
            if (shield == 0)
            {
                health = health - dmg;
                Console.WriteLine("Enemy has taken " + dmg + " damage.");
                Console.WriteLine("");
                DeathCheck();
                RangeChecking();
            }
            if (shield > 0 && livesBefore == lives)
            {
                shield = shield - dmg;
                Console.WriteLine("Enemy's shield has taken " + dmg + " damage.");
                Console.WriteLine("");
                if (shield < 0)
                {
                    health = health + shield;
                    Console.WriteLine("Enemy has taken " + -shield + " damage through their shield.");
                    Console.WriteLine("");
                    DeathCheck();
                    RangeChecking();
                }
                RangeChecking();
            }
        }
        public void DeathCheck()
        {
            if (health <= 0)
            {
                lives = lives - 1;
                health = 100;
                shield = 100;
                Console.WriteLine("A live has been lost.");
                Console.WriteLine("");
            }
            else
            {
            }
        }
        public void Heal(int heal)
        {
            if (health < 100 && health > 0)
            {
                health = health + heal;
                RangeChecking();
                Console.WriteLine("Enemy health has regenerated " + heal + " hitpoints"); //will display more HP than regen EX: regen 10 hp when at 95 HP displays 10 regen'd HP
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Enemy health is full is full.");
                Console.WriteLine("");
            }
        }
        public void ShowHUD()
        {
            Console.WriteLine(name);
            Console.WriteLine("Enemy Health: " + health + "/" + maxHealth);
            Console.WriteLine("Enemy Shield: " + shield + "/" + maxShield);
            Console.WriteLine("Enemy Lives: " + lives + "/" + maxLives);
            Console.WriteLine("");
        }
        public void RegenerateShield(int rgn)
        {
            if (shield < 100)
            {
                shield = shield + rgn;
                RangeChecking();
                Console.WriteLine("Enemy shield has regenerated " + rgn + " hitpoints"); //same issue as health
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Enemy shield is full.");
                Console.WriteLine("");
            }
        }
    }
}
