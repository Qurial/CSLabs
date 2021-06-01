using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public class EnemyArcher : Enemy, IEnemyType
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
        public EnemyArcher(string name, int age)
        {
            NPCTypeInit = "Archer";
            base.GetInfo(NPCType, name, age);
            Weapon = "Bow";
        }
    }
}