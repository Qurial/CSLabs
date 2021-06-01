using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab35
{
    public class EnemyArcher : Enemy
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
            if (NPCType == "archer" || NPCType == "Archer")
            {
                base.GetInfo(NPCType, name, age);
                Weapon = "Bow";
                Info inf = new Info();
                inf.WriteInfo(name, age, angerToPlayer, NPCType, weapon);
            }
        }
    }
}