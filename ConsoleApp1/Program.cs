using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Magic()
        {
            Console.WriteLine("Type Some Text");
            string Text = Console.ReadLine();
            Console.WriteLine($"This is your text: {Text}");
        }
        static void Main(string[] args)
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
    }
}
