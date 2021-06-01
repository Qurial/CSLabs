using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab35
{
    public class Enemy : NPC
    {
        protected bool angerToPlayer;
        public override void GetInfo(string NPCType, string name, int age)
        {
            base.GetInfo(NPCType, name, age);
            angerToPlayer = true;
        }
    }
}
