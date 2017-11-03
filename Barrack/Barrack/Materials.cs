using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Materials
    {
        private int people = 10;
        private int spear = 10;
        private int bow = 10;
        private int crossbow = 10;
        private int horse = 10;
        private int gold = 1000;

        public int People { get => people; set => people = value; }
        public int Spear { get => spear; set => spear = value; }
        public int Bow { get => bow; set => bow = value; }
        public int Crossbow { get => crossbow; set => crossbow = value; }
        public int Horse { get => horse; set => horse = value; }
        public int Gold { get => gold; set => gold = value; }
    }
}
