using System;
using System.Collections.Generic;

namespace CSLab3568
{
    public delegate int AverageAge(List<IEnemyType> enemies);
    public delegate string ConcatenationStrings(IEnemyType enemy);
    class Program
    {
        static void Main(string[] args)
        {
            AverageAge AvAge = delegate (List<IEnemyType> e)
            {
                int age = 0, k = 0;
                foreach (IEnemyType i in e)
                {
                    age += i.Age;
                    k++;
                }
                return age / k;
            };
            Enemy en = new Enemy();
            AddEnemy dAdd = new AddEnemy(en.AddEnemies);
            FullInfo WriteInfo = new FullInfo(en.WriteInfo);
            ConcatenationStrings CStr = (IEnemyType en) => en.NPCTypeInit + " " + en.Name;
            MxMnAge MinAge = new MxMnAge(en.MinAge);
            MxMnAge MaxAge = new MxMnAge(en.MaxAge);
            List<IEnemyType> enemies = new List<IEnemyType>
            {
                new EnemyArcher("Boris", 23),
                new EnemyWarrior("Yaroslav", 54),
                new EnemyAssassin("Eugen", 32),
                new EnemyArcher("Anton", 34)
            };
            string answer;
            while (true)
            {
                Console.WriteLine("What do you want to do(add, sort, info, age, squad, exit)?");
                answer = Console.ReadLine();
                Console.Clear();
                if (answer == "add")
                {
                    dAdd(enemies);
                }
                if (answer == "sort")
                {
                    enemies.Sort();
                    int max = MaxAge(enemies);
                    int min = MinAge(enemies);
                    enemies.ForEach(enemy => enemy.GetShortInfo(max, min));
                }
                if (answer == "info")
                {
                    Console.WriteLine("Enter a name of the enemy: ");
                    string name = Console.ReadLine();
                    foreach (IEnemyType i in enemies)
                    {
                        if(name == i.Name)
                        {
                            WriteInfo(i);
                        }
                    }
                }
                if (answer == "age")
                {
                    Console.WriteLine($"Average age is: {AvAge(enemies)}");
                }
                if (answer == "squad")
                {
                    List<string> enems = new List<string> { };
                    foreach (IEnemyType i in enemies)
                    {
                        enems.Add(CStr(i));
                    }
                    enems.Sort();
                    enems.ForEach(enemy => Console.WriteLine(enemy));
                }
                if (answer == "exit")
                {
                    break;
                }
            }
        }
    }
}
