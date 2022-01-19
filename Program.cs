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
            Console.WriteLine("HealthSystemV2.0");
            Console.WriteLine("V2.0 = w/ OOP");
            Console.WriteLine("");

            Player player = new Player("Jacob Yeomans");

            player.ShowHUD();
            Console.WriteLine("");
            player.TakeDamage(35);
            Console.WriteLine("");
            player.ShowHUD();


            Console.ReadKey(true);
        }
    }
}
