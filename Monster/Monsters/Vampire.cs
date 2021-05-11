using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Vampire;

namespace Monster.Monsters
{
    class Vampire : IMonster
    {
        private string name = "Blade";
        string IMonster.Name { get => name; set => name = value; }

        string Attack => ATTACK;

        string Defend => DEFEND;

        string Scare => SCARE;

        string SecondaryAttack => SECONDARYATTACK;

        new string ToString => TOSTRING;

    }
}
