using System;

namespace CSLab2
{
    class Program
    {
        static char[] ReplaceLetter(char[] array, int i)
        {
            switch (array[i])
            {
                case 'a': array[i] = 'b'; break;
                case 'b': array[i] = 'c'; break;
                case 'c': array[i] = 'd'; break;
                case 'd': array[i] = 'e'; break;
                case 'e': array[i] = 'f'; break;
                case 'f': array[i] = 'g'; break;
                case 'g': array[i] = 'h'; break;
                case 'h': array[i] = 'i'; break;
                case 'i': array[i] = 'j'; break;
                case 'j': array[i] = 'k'; break;
                case 'k': array[i] = 'l'; break;
                case 'l': array[i] = 'm'; break;
                case 'm': array[i] = 'n'; break;
                case 'n': array[i] = 'o'; break;
                case 'o': array[i] = 'p'; break;
                case 'p': array[i] = 'q'; break;
                case 'q': array[i] = 'r'; break;
                case 'r': array[i] = 's'; break;
                case 's': array[i] = 't'; break;
                case 't': array[i] = 'u'; break;
                case 'u': array[i] = 'v'; break;
                case 'v': array[i] = 'w'; break;
                case 'w': array[i] = 'x'; break;
                case 'x': array[i] = 'y'; break;
                case 'y': array[i] = 'z'; break;
                case 'z': array[i] = 'a'; break;
                case ' ': array[i] = ' '; break;
                default: array[i] = '1'; break;
            }
            return array;
        }
        static string TransformLine(string str)
        {
            char[] array = str.ToCharArray();
            char[] testArray = str.ToCharArray();
            int k = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1)
                {
                    switch (array[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'y': array = ReplaceLetter(array, (i + 1)); break;
                    }
                }
                testArray = ReplaceLetter(testArray, i);
                if (testArray[i] == '1')
                {
                    k++;
                    break;
                }
            }
            str = new string(array);
            if (k > 0)
            {
                str = "Wrong input";
            }

            Console.WriteLine("");
            return str;
        }
        static int[] TimeComposition(string time)
        {
            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            char[] array = time.ToCharArray();
            for (int i = 0; i < time.Length; i++)
            {
                switch (array[i])
                {
                    case '0': numbers[0]++; break;
                    case '1': numbers[1]++; break;
                    case '2': numbers[2]++; break;
                    case '3': numbers[3]++; break;
                    case '4': numbers[4]++; break;
                    case '5': numbers[5]++; break;
                    case '6': numbers[6]++; break;
                    case '7': numbers[7]++; break;
                    case '8': numbers[8]++; break;
                    case '9': numbers[9]++; break;
                }
            }
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("The number of ");
                Console.Write(i);
                Console.Write(": ");
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("");
            return numbers;
        }
        static int MaxPower(int firstNum, int secondNum)
        {
            long factorial = 1;

            while (firstNum <= secondNum)
            {
                factorial *= firstNum;
                firstNum++;
            }

            long remainder = 0;
            long two = 2, i = 0;
            do
            {
                i++;
                long div = Math.DivRem(factorial, (long)Math.Pow(two, i), out remainder);
            } while (remainder == 0);
            return Convert.ToInt32(i - 1);
        }

        static void Main(string[] args)
        {
            string answer = "";
            while (answer != "exit")
            {
                Console.Clear();
                Console.WriteLine("Choose ation (function1, function2, function3, exit)");
                answer = Console.ReadLine();
                if (answer == "function1")
                {
                    string str;
                    Console.WriteLine("Input string:");
                    str = Console.ReadLine();
                    str = TransformLine(str);

                    Console.WriteLine("New string:");
                    Console.WriteLine(str);
                    Console.WriteLine("");
                }

                else if (answer == "function2")
                {
                    string time1Format = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                    string time2Format = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

                    Console.WriteLine(time1Format);
                    int[] timeNums1 = TimeComposition(time1Format);

                    Console.WriteLine(time2Format);
                    int[] timeNums2 = TimeComposition(time2Format);
                }

                else if (answer == "function3")
                {
                    string num;
                    int firstNum, secondNum;

                    Console.WriteLine("Input first num:");
                    num = Console.ReadLine();
                    firstNum = Convert.ToInt32(num);

                    Console.WriteLine("Input second num:");
                    num = Console.ReadLine();
                    secondNum = Convert.ToInt32(num);

                    int pow = MaxPower(firstNum, secondNum);
                    Console.WriteLine("Max power is:");
                    Console.WriteLine(pow);
                }
                else if (answer == "exit") { }

                else
                {
                    Console.WriteLine("Wrong input. Try again");
                }

                if (answer != "exit") { Console.ReadKey(); }
            }
        }
    }
}
