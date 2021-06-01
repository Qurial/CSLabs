using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab35
{
    public class NPC
    {
        protected string name;
        protected int age;
        protected string NPCType;
        protected string Name
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
        protected int Age
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
        //public NPC() { Name = "Bob"; Age = 18; }
        //public NPC(string x) { Name = x; Age = 18; }
        //public NPC(string x, int y) { Name = x; Age = y; }
        public virtual void GetInfo(string NPCType, string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}
