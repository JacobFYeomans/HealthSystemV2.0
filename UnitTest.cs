using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2._0
{
    class UnitTest
    {
        public void RunUnitTest()
        {
            Player player = new Player("testPlayer");
            Enemy enemy = new Enemy("testEnemy");

            player.UnitTest();
            enemy.UnitTest();
        }
    }
}
