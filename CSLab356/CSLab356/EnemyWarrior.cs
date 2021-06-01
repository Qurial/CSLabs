using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public class EnemyWarrior : Enemy, IEnemyType
    {
        string weapon;
        public string Weapon
        {
            get
            {
                return weapon;
            }

            set
            {
                weapon = value;
            }
        }
        public void GetFullInfo()
        {
            Info inf = new Info();
            inf.WriteInfo(name, age, angerToPlayer, NPCType, weapon);
        }
        public void GetShortInfo()
        {
            Console.WriteLine($"{name}: {NPCType}, {age}.");
        }
        public int CompareTo(IEnemyType other)
        {
            return Name.CompareTo(other.Name);
        }
        public EnemyWarrior(string name, int age)
        {
            NPCTypeInit = "Warrior";
            base.GetInfo(NPCType, name, age);
            Weapon = "Sword";
        }
    }
}