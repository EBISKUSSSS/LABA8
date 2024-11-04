using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace IHateAsync
{
    class Program
    {
        public static async Task ReadVerse1()
        {
              Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Critter 1");
            if (File.Exists("C:/C#/ASYNC L8/v1.txt"))
            {
                string textVerse1 = await File.ReadAllTextAsync("C:/C#/ASYNC L8/v1.txt");
                Console.WriteLine(textVerse1);
            }
            else
            {
                Console.WriteLine("File v1.txt not found.");
            }
        }

        public static async Task ReadVerse2()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Critter 2");
            if (File.Exists("C:/C#/ASYNC L8/v2.txt"))
            {
                string textVerse2 = await File.ReadAllTextAsync("C:/C#/ASYNC L8/v2.txt");
                Console.WriteLine(textVerse2);
            }
            else
            {
                Console.WriteLine("File v2.txt not found.");
            }
        }

        public static async Task ReadVerse3()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Critter 3");
            if (File.Exists("C:/C#/ASYNC L8/v3.txt"))
            {
                string textVerse3 = await File.ReadAllTextAsync("C:/C#/ASYNC L8/v3.txt");
                Console.WriteLine(textVerse3);
            }
            else
            {
                Console.WriteLine("File v3.txt not found.");
            }
        }

        static async Task Main(string[] args)
        {
            var tasks = new List<Task> { ReadVerse1(), ReadVerse2(), ReadVerse3() };
            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed.");
        }
    }
}
