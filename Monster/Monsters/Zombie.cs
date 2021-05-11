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
        string IMonster.Name { get => name; set => name = value; }

        string Attack => ATTACK;

        string Defend => DEFEND;

        string Scare => SCARE;

        new string ToString => TOSTRING;

    }
}
