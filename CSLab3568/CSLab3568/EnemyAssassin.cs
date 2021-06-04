using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab3568
{
    public class EnemyAssassin : Enemy, IEnemyType
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

        public EnemyAssassin(string name, int age)
        {
            NPCTypeInit = "Assassin";
            base.GetInfo(NPCType, name, age);
            Weapon = "Knife";
        }
    }
}
