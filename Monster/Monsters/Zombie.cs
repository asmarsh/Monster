using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Zombie;

namespace Monster.Monsters
{
    class Zombie : IMonster
    {
        private string name = "Walker";
        public string Name { get => name; set => name = value; }

        public string Attack() => ATTACK;

        public string Defend() => DEFEND;

        public string Scare() => SCARE;

        public override string ToString() => TOSTRING;

    }
}
