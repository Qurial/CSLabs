using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab3568
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
        public EnemyArcher(string name, int age)
        {
            NPCType = "Archer";
            base.GetInfo(NPCType, name, age);
            Weapon = "Bow";
        }
    }
}