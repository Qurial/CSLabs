using System;
using System.Collections.Generic;

namespace CSLab35
{
    class Program
    {
        static void Main(string[] args)
        {
            var NPCs = new List<NPC>
            {
                new EnemyArcher(),
                new EnemyWarrior(),
                new EnemyAssassin()
            };
            foreach (var NPC in NPCs)
            {
                NPC.GetInfo("Assassin", "John", 44);
            }
        }
    }
}
