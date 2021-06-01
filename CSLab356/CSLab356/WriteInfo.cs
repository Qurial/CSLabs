using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public class Info
    {
        public void WriteInfo(string name, int age, bool angToPlr, string NPCType, string weapon)
        {
            Console.WriteLine("Object: NPC");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            if (angToPlr == true) { Console.WriteLine($"Class: Enemy"); }
            else { Console.WriteLine($"Class: Peaceful"); }
            Console.WriteLine($"Specizlization: {NPCType}");
            Console.WriteLine($"Main weapon: {weapon}");
        }
    }
}
