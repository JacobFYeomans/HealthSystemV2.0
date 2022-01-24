using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    abstract class GameCharacter
    {
        protected string name;
        protected int health = 100;
        protected int lives = 99;
        protected int shield = 100;

        protected int maxLives = 99;
        protected const int maxHealth = 100;
        protected const int maxShield = 100;
        protected const int minHealth = 0;
        protected const int minShield = 0;
        protected const int minLives = 0;

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
            if (shield == 0 && dmg > 0)
            {
                health = health - dmg;
                Console.WriteLine("GameCharacter has taken " + dmg + " damage.");
                Console.WriteLine("");
                DeathCheck();
                RangeChecking();
            }
            if (shield > 0 && livesBefore == lives && dmg > 0)
            {
                shield = shield - dmg;
                Console.WriteLine("GameCharacter's shield has taken " + dmg + " damage.");
                Console.WriteLine("");
                if (shield < 0 && dmg > 0)
                {
                    health = health + shield;
                    Console.WriteLine("GameCharacter has taken " + -shield + " damage through their shield.");
                    Console.WriteLine("");
                    DeathCheck();
                    RangeChecking();
                }
                RangeChecking();
                if (dmg < 0)
                {
                    Console.WriteLine("Invalid Damage Amount");
                }
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
            if (health < 100 && health > 0 && heal > 0)
            {
                health = health + heal;
                RangeChecking();
                Console.WriteLine("GameCharacter's health has regenerated " + heal + " hitpoints"); //will display more HP than regen EX: regen 10 hp when at 95 HP displays 10 regen'd HP
                Console.WriteLine("");
            }
            if ( health == 100)
            {
                Console.WriteLine("GameCharacter's health is full.");
                Console.WriteLine("");
            }
            if (heal < 0)
            {
                Console.WriteLine("Invalid Heal Amount.");
            }
        }
        public void ShowHUD()
        {
            Console.WriteLine(name);
            Console.WriteLine("GameCharacter's Health: " + health + "/" + maxHealth);
            Console.WriteLine("GameCharacter's Shield: " + shield + "/" + maxShield);
            Console.WriteLine("GameCharacter's Lives: " + lives + "/" + maxLives);
            Console.WriteLine("");
        }
        public void RegenerateShield(int rgn)
        {
            if (shield < 100 && rgn > 0)
            {
                shield = shield + rgn;
                RangeChecking();
                Console.WriteLine("GameCharacter's shield has regenerated " + rgn + " hitpoints"); //same issue as health
                Console.WriteLine("");
            }
            if (shield == 100)
            {
                Console.WriteLine("GameCharacter's shield is full.");
                Console.WriteLine("");
            }
            if (rgn < 0)
            {
                Console.WriteLine("Invalid Regen Amount.");
            }
        }

    }
}
