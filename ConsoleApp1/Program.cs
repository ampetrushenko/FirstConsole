using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Magic()
        {
            Console.WriteLine("Type Some Text");
            string Text = Console.ReadLine();
            Console.WriteLine($"This is your text: \"{Text}\"!\nEnd...");
        }
        public static void Start()
        {
            Console.WriteLine("Select task:");
            byte TaskNumber = byte.Parse(Console.ReadLine());
            switch (TaskNumber)
            {
                case 1:
                    Magic();
                    break;
                default:
                    Console.WriteLine("Something wen wrong!");
                    break;
            }
        }
        public static int[,] Generate2Massives()
        {
            int[,] arr = new int [2,10];
            byte x0 = 0;
            byte x1 = 0;
            int raws = arr.GetUpperBound(0) + 1;
            int columns = arr.Length/2;

            Console.WriteLine("Введите 10 целых чисел...");
            for (int i = 0; i < 10; i++)
            {
                int key = int.Parse(Console.ReadLine());

                if (key % 2 == 0)
                {
                    arr[0, x0] = key;
                    x0++;

                }
                else
                {
                    arr[1, x1] = key;
                    x1++;
                }
            }
            Console.WriteLine("-------------------------");
            return arr;
        }
        static void Main(string[] args)
        {
            
            int[,] MyArray = Generate2Massives();
            int a = 0;
            int b = 0;
            for (int i = 0; i < MyArray.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < MyArray.Length/(MyArray.GetUpperBound(0) + 1); j++)
                {
                    
                    if (j != ((MyArray.Length / (MyArray.GetUpperBound(0) + 1))-1)) 
                    {
                        Console.Write($"{MyArray[i, j]}, ");
                       
                    }
                    else
                    {
                        Console.WriteLine($"{MyArray[i, j]}");
                    }
                    if (i == 0 && MyArray[i, j] != 0)
                    {
                        a++;
                    }
                    if (i == 1 && MyArray[i, j] != 0)
                    {
                        b++;
                    }

                }
            }
            Console.WriteLine($"Четных: {a}, нечетных: {b}");
        }
    }
}
