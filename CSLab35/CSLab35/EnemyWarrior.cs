using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab35
{
    class EnemyWarrior : Enemy
    {
        string weapon;
        protected string Weapon
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
        public override void GetInfo(string NPCType, string name, int age)
        {
            if (NPCType == "warrior" || NPCType == "Warrior")
            {
                base.GetInfo(NPCType, name, age);
                Weapon = "Sword";
                Info inf = new Info();
                inf.WriteInfo(name, age, angerToPlayer, NPCType, weapon);
            }
        }
    }
}
