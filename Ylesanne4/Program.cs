﻿using System;
using System.IO;
namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\samples\titpe21";
            Console.WriteLine("What file would you like to be displayed?");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool excists = File.Exists(fileDirect);
            if (excists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "toyota" || userFile == "bmw" || userFile == "tesla")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file does not exist.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt file does not exist.");

            }
        }
    }
    
}
