﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Player
{
    class Mage : Player
    {
        public Wand MainHand { get; set; }
        public Spellbook OffHand { get; set; }
    }
}
