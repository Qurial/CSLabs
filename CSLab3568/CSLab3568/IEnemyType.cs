using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab3568
{
    public interface IEnemyType : IComparable<IEnemyType>
    {
        string Weapon { get; set; }
        void GetShortInfo(int max, int min);
        string Name { get; set; }
        int Age { get; set; }
        bool AngerToPlayer { get; set; }
        public string NPCTypeInit { get; set; }
    }
}
