using Monster.Monsters;
using System;
using System.Collections.Generic;

namespace Monster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are walking through the forest on a moonlit night.");

            var monsters = new List<IMonster>()
            {
                new Ghost(),
                new Zombie()
            };
            foreach (var monster in monsters)
            {
                Console.WriteLine($"You see a {monster.GetType().Name } named {monster.Name}.");
                Console.WriteLine("The monster speaks!");
                Console.WriteLine(monster.ToString());
                Console.WriteLine("The monster attacks!");
                Console.WriteLine(monster.Attack());
                Console.WriteLine("The monster tries to scare you!");
                Console.WriteLine(monster.Scare());
                Console.WriteLine("The monster defends!");
                Console.WriteLine(monster.Defend());
            }


            var moreMonsters = new List<IMonsterWithSecondary>()
            {
                new Vampire(),
                new Werewolf()
            };

            foreach (var monster in moreMonsters)
            {
                Console.WriteLine($"You see a {monster.GetType().Name } named {monster.Name}.");
                Console.WriteLine("The monster speaks!");
                Console.WriteLine(monster.ToString());
                Console.WriteLine("The monster attacks!");
                Console.WriteLine(monster.Attack());
                Console.WriteLine("The monster tries to scare you!");
                Console.WriteLine(monster.Scare());
                Console.WriteLine("The monster attacks again!");
                Console.WriteLine(monster.SecondaryAttack());
                Console.WriteLine("The monster defends!");
                Console.WriteLine(monster.Defend());
            }
             
            Console.ReadKey();
        }
    }
}
