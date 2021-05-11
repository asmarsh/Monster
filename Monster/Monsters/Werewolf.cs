using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Werewolf;

namespace Monster.Monsters
{
    class Werewolf : IMonster
    {
        private string name = "Mason";
        string IMonster.Name { get => name; set => name = value; }

        string Attack => ATTACK;

        string Defend => DEFEND;

        string Scare => SCARE;

        string SecondaryAttack => SECONDARYATTACK;

        new string ToString => TOSTRING;

    }
}
