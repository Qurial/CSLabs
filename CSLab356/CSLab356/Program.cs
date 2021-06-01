using System;
using System.Collections.Generic;

namespace CSLab356
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEnemyType> enemies = new List<IEnemyType>
            {
                new EnemyArcher("Boris", 23),
                new EnemyWarrior("Yaroslav", 43),
                new EnemyAssassin("Eugen", 36),
                new EnemyArcher("Anton", 54)
            };
            string answer;
            while (true)
            {
                Console.WriteLine("What do you want to do(add, sort, exit)?");
                answer = Console.ReadLine();
                Console.Clear();
                if (answer == "add")
                {
                    AddEnemy add = new AddEnemy();
                    add.AddEnemies(enemies);
                }
                if (answer == "sort")
                {
                    enemies.Sort();
                    enemies.ForEach(enemy => enemy.GetShortInfo());
                }
                if(answer == "exit")
                {
                    break;
                }
            }
        }
    }
}
