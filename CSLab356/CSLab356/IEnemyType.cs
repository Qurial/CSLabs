using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public interface IEnemyType : IComparable<IEnemyType>
    {
        string Weapon { get; set; }
        void GetFullInfo();
        void GetShortInfo();
        string Name { get; set; }
    }
}
