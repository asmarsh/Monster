using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Werewolf;

namespace Monster.Monsters
{
    public class Werewolf : IMonster
    {
        private string name = "Mason";
        public string Name { get => name; set => name = value; }

        string Attack => ATTACK;

        string Defend => DEFEND;

        string Scare => SCARE;

        string SecondaryAttack => SECONDARYATTACK;

        new string ToString => TOSTRING;

    }
}
