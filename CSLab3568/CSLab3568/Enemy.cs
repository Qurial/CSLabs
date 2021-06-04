using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSLab3568
{
    public delegate List<IEnemyType> AddEnemy(List<IEnemyType> enemies);
    public delegate void FullInfo(IEnemyType enemy);
    public delegate int MxMnAge(List<IEnemyType> enemies);
    public delegate void MinAndMaxAges();

    public class Enemy : NPC
    {
        public bool angerToPlayer;
        public bool AngerToPlayer
        {
            get
            {
                return angerToPlayer;
            }

            set
            {
                angerToPlayer = value;
            }
        }
        public event MinAndMaxAges MinAgeEvent;
        public event MinAndMaxAges MaxAgeEvent;
        public override void GetInfo(string NPCType, string name, int age)
        {
            base.GetInfo(NPCType, name, age);
            angerToPlayer = true;
        }
        public List<IEnemyType> AddEnemies(List<IEnemyType> enemies)
        {
            string type, name, answer;
            bool isCorrect;
            int age;
            IEnemyType enem;

            while (true)
            {
                Console.Write("Name of the enemy is: ");
                name = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.Write("Age of the enemy is: ");
                        age = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong input. Try again: ");
                    }
                }
                do
                {
                    isCorrect = true;
                    Console.Write("Type of the enemy is: ");
                    type = Console.ReadLine();

                    switch (type)
                    {
                        case "Archer":
                        case "archer":
                            enem = new EnemyArcher(name, age);
                            enemies.Add(enem);
                            break;
                        case "Warrior":
                        case "warrior":
                            enem = new EnemyWarrior(name, age);
                            enemies.Add(enem);
                            break;
                        case "Assassin":
                        case "assassin":
                            enem = new EnemyAssassin(name, age);
                            enemies.Add(enem);
                            break;
                        default:
                            Console.WriteLine("There is no such type of a enemy. Try again");
                            isCorrect = false;
                            break;
                    }
                } while (isCorrect == false);

                Console.WriteLine("Do you want to contiune? ");
                answer = Console.ReadLine();

                if (answer != "yes") { break; }
            }
            return enemies;
        }
        public void WriteInfo(IEnemyType e)
        {
            Console.WriteLine("Object: NPC");
            Console.WriteLine($"Name: {e.Name}");
            Console.WriteLine($"Age: {e.Age}");
            if (e.AngerToPlayer == true) { Console.WriteLine($"Class: Enemy"); }
            else { Console.WriteLine($"Class: Peaceful"); }
            Console.WriteLine($"Specizlization: {e.NPCTypeInit}");
            Console.WriteLine($"Main weapon: {e.Weapon}");
        }
        public void AgeEvents(int max, int min)
        {
            if (age == min) { MinAgeEvent(); }
            else if (age == max) { MaxAgeEvent(); }
        }
        public static void WriteMin() { Console.Write(" -Youngest"); }
        public static void WriteMax() { Console.Write(" -Oldest"); }
        public void GetShortInfo(int max, int min)
        {
            Console.Write($"{name}: {NPCType}, {age}.");
            //Enemy enem = new Enemy();
            MinAgeEvent += WriteMin;
            MaxAgeEvent += WriteMax;
            AgeEvents(max, min);
            Console.Write("\n");
        }
        public int CompareTo(IEnemyType other)
        {
            return Name.CompareTo(other.Name);
        }
        public int MinAge(List<IEnemyType> enemies)
        {
            List<int> ages = new List<int> { };
            foreach (IEnemyType i in enemies)
            {
                ages.Add(i.Age);
            }
            int min = ages.Min();
            return min;
        }
        public int MaxAge(List<IEnemyType> enemies)
        {
            List<int> ages = new List<int> { };
            foreach (IEnemyType i in enemies)
            {
                ages.Add(i.Age);
            }
            int max = ages.Max();
            return max;
        }
    }
}
