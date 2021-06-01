using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab35
{
    class EnemyAssassin : Enemy
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
            if (NPCType == "assassin" || NPCType == "Assassin")
            {
                base.GetInfo(NPCType, name, age);
                Weapon = "Knife";
                Info inf = new Info();
                inf.WriteInfo(name, age, angerToPlayer, NPCType, weapon);
            }
        }
    }
}
