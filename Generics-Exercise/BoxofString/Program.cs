﻿namespace BoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Box<string> box = new Box<string>(input);
            //    Console.WriteLine(box.ToString());
            //}

            //Задача 2

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
