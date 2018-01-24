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
        static void Main(string[] args)
        {
            DriveInfo[] Drivers = DriveInfo.GetDrives();
            foreach (DriveInfo Driver in Drivers)
            {
                Console.WriteLine($"Disk: {Driver.Name}. Available space: {Math.Round((Driver.TotalFreeSpace * 0.000000001),2)}Gb of {Math.Round((Driver.TotalSize * 0.000000001),2)}Gb");
            }
        }
    }
}
