using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Monster
{
    class Monster
    {
        public MonsterType Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
    }
}
