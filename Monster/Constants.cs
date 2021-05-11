using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    class Constants
    {
        public class Ghost
        {
            public const string ATTACK = "You've been slimed!";
            public const string SCARE = "Boo!";
            public const string DEFEND = "disappear";
            public const string TOSTRING = "I am a Ghost!";
        }

        public class Vampire
        {
            public const string ATTACK = "You have been bitten!";
            public const string SCARE = "I am a vampire!";
            public const string SECONDARYATTACK = "You have been compelled to do my bidding!";
            public const string DEFEND = "Turn into a bat and fly away...";
            public const string TOSTRING = "I am a Vampire!";
        }

        public class Zombie
        {
            public const string ATTACK = "You have been bitten!";
            public const string SCARE = "Scream!";
            public const string DEFEND = "";
            public const string TOSTRING = "I am a Zombie!";
        }

        public class Werewolf
        {
            public const string ATTACK = "Bite!";
            public const string SCARE = "Growl!";
            public const string DEFEND = "Run away!";
            public const string SECONDARYATTACK = "Claw!";
            public const string TOSTRING = "I am a Lycanthrope!";
        }

    }
}
