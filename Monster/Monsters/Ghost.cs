using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Ghost;

namespace Monster.Monsters
{
    class Ghost : IMonster
    {
        private string name => "Casper";
        string IMonster.Name { get => name; }

        string Attack => ATTACK;

        string Defend => DEFEND;

        string Scare => SCARE;

        new string ToString => TOSTRING;

    }
}
