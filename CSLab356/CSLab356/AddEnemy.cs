using System;
using System.Collections.Generic;
using System.Text;

namespace CSLab356
{
    public class AddEnemy
    {
        public List<IEnemyType> AddEnemies(List<IEnemyType> enemies)
        {
            string type, name, answer;
            bool isCorrect = true, isAdd = true, formatExceptionError;
            int age = 0;
            while (isAdd == true)
            {
                Console.Write("Name of the enemy is: ");
                name = Console.ReadLine();
                formatExceptionError = true;
                while (formatExceptionError == true)
                {
                    try
                    {
                        Console.Write("Age of the enemy is: ");
                        age = Int32.Parse(Console.ReadLine());
                        formatExceptionError = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong input. Try again: ");
                        formatExceptionError = true;
                    }
                }
                do
                {
                    isCorrect = true;
                    Console.Write("Type of the enemy is: ");
                    type = Console.ReadLine();
                    IEnemyType enem;
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
                            Console.WriteLine("There is no such type of a enemy. Press any key to try again");
                            Console.ReadKey();
                            isCorrect = false;
                            break;
                    }
                } while (isCorrect == false);
                Console.WriteLine("Do you want to contiune? ");
                answer = Console.ReadLine();
                if (answer != "yes")
                {
                    isAdd = false;
                }
            }
            return enemies;
        }
    }
}
