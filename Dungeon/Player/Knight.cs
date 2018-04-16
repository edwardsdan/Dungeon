using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Player
{
    class Knight : Player
    {
        public int Shield { get; set; }
        public Sword MainHand { get; set; }
        public Flail OffHand { get; set; }
    }
}
