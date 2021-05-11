using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Ghost;

namespace Monster.Monsters
{
    public class Ghost : IMonster
    {
        private string name = "Casper";
        public string Name { get => name; set => name = value; }

        public string Attack() => ATTACK;

        public string Defend() => DEFEND;

        public string Scare() => SCARE;

        public override string ToString() => TOSTRING;

    }
}
