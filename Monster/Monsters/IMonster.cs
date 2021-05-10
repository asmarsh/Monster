using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    interface IMonster
    {
        public string Name { get; }


        string Attack()
        {
            throw new NotImplementedException();
        }

        string Scare()
        {
            throw new NotImplementedException();
        }

        string Defend()
        {
            throw new NotImplementedException();
        }

        string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
