using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public class NPC
    {
        protected string name;
        protected int age;
        public string NPCType;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public string NPCTypeInit
        {
            get
            {
                return NPCType;
            }

            set
            {
                NPCType = value;
            }
        }
        public void init(string type, string name, int age)
        {
            NPCTypeInit = type;
            Name = name;
            Age = age;
        }
        public virtual void GetInfo(string NPCType, string name, int age)
        {
            Age = age;
            Name = name;
            NPCTypeInit = NPCType;
        }
    }
}
