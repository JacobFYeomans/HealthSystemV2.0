using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTest unitTest = new UnitTest();
            unitTest.RunUnitTest();
            Console.Clear();

            Console.WriteLine("Health System");
            Console.WriteLine("V3.0 = w/ OOP & Inheritance");
            Console.WriteLine("");

            Player player = new Player("Jacob Yeomans");
            Enemy enemy = new Enemy("Game Development");

            player.ShowHUD();
            player.TakeDamage(35);
            player.ShowHUD();
            player.TakeDamage(60);
            player.ShowHUD();
            player.RegenerateShield(15);
            player.ShowHUD();
            player.TakeDamage(75);
            player.ShowHUD();
            player.Heal(5);
            player.ShowHUD();
            player.TakeDamage(100);
            player.ShowHUD();
            player.TakeDamage(200);
            player.ShowHUD();

            enemy.ShowHUD();
            enemy.TakeDamage(35);
            enemy.ShowHUD();
            enemy.TakeDamage(60);
            enemy.ShowHUD();
            enemy.RegenerateShield(15);
            enemy.ShowHUD();
            enemy.TakeDamage(75);
            enemy.ShowHUD();
            enemy.Heal(5);
            enemy.ShowHUD();
            enemy.TakeDamage(100);
            enemy.ShowHUD();
            enemy.TakeDamage(200);
            enemy.ShowHUD();

            Console.ReadKey(true);
        }
    }
}
