using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    interface IMonster
    {
        abstract string Name { get; set; }


        abstract string Attack();

        abstract string Scare();

        abstract string Defend();

        abstract string ToString();
    }

    interface IMonsterWithSecondary : IMonster
    {
        abstract string SecondaryAttack();
    }
}
