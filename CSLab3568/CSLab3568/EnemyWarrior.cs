using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab3568
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
        public EnemyWarrior(string name, int age)
        {
            NPCTypeInit = "Warrior";
            base.GetInfo(NPCType, name, age);
            Weapon = "Sword";
        }
    }
}