using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monster.Constants.Werewolf;

namespace Monster.Monsters
{
    public class Werewolf : IMonsterWithSecondary
    {
        private string name = "Mason";
        public string Name { get => name; set => name = value; }

        public string Attack() => ATTACK;

        public string Defend() => DEFEND;

        public string Scare() => SCARE;

        public string SecondaryAttack() => SECONDARYATTACK;

        public override string ToString() => TOSTRING;

    }
}
