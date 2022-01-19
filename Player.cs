using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class Player
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
            if (shield == 0)
            {
                health = health - dmg;
                Console.WriteLine("Player has taken " + dmg + " damage.");
                Console.WriteLine("");
                DeathCheck();
                RangeChecking();
            }
            if (shield > 0)
            {
                shield = shield - dmg;
                Console.WriteLine("Player's shield has taken " + dmg + " damage.");
                Console.WriteLine("");
                if (shield < 0)
                {
                    health = health + shield;
                    Console.WriteLine("Player has taken " + -shield + " damage through their shield.");
                    Console.WriteLine("");
                    DeathCheck();
                    RangeChecking();
                }
                RangeChecking();
            }
        }
        public void DeathCheck()
        {
            if (health < 0)
            {
                lives = lives - 1;
                health = 100;
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
                Console.WriteLine("Health has regenerated " + heal + " hitpoints"); //will display more HP than regen EX: regen 10 hp when at 95 HP displays 10 regen'd HP
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Health is full is full.");
                Console.WriteLine("");
            }
        }
        public void ShowHUD()
        {
            Console.WriteLine(name);
            Console.WriteLine("Player Health: " + health + "/" + maxHealth);
            Console.WriteLine("Player Shield: " + shield + "/" + maxShield);
            Console.WriteLine("Player Lives: " + lives + "/" + maxLives); // 99/99???????
            Console.WriteLine("");
        }
        public void RegenerateShield(int rgn)
        {
            if (shield < 100)
            {
                shield = shield + rgn;
                RangeChecking();
                Console.WriteLine("Shield has regenerated " + rgn + " hitpoints"); //same issue as health
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Shield is full.");
                Console.WriteLine("");
            }
        }
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
    }
}
