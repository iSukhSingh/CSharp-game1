﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;
            Console.WriteLine("Welcome to rock paper scissors!");
            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors.");
                string playerChoice = Console.ReadLine();
                int enemyChoice = random.Next(0, 3);
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }
        }
    }
}