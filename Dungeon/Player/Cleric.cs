using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Player
{
    class Cleric : Player
    {
        public int Shield { get; set; }
        public ClericWeapon Weapon { get; set; }
    }
}
