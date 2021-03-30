﻿using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name?");
            string name = Console.ReadLine();

            var game = new Game(name);

            Console.WriteLine($"{game.Winner} wins.");
        }
    }
}
