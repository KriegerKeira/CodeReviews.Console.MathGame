﻿using mathGame.kriegerKeira.Models;

namespace mathGame.kriegerKeira;
public class GameEngine
{
    public static void AdditionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        for (int i = 0; i < 5; i++)
        {
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("That is correct! Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
                score++;
            }
            else
            {
                Console.WriteLine("That is incorrect... Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            if(i != 4) continue;
            Console.WriteLine($"Game over! Your score was: {score}pts. Returning to main menu...");
            Thread.Sleep(3000);
        }
        Helpers.AddToHistory(score, GameType.Addition);
    }

    public static void SubtractionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        for (int i = 0; i < 5; i++)
        {
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("That is correct! Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
                score++;
            }
            else
            {
                Console.WriteLine("That is incorrect... Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
            }

            if (i != 4) continue;
            Console.WriteLine($"Game over! Your score was: {score}pts. Returning to main menu...");
            Thread.Sleep(3000);
        }
        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    public static void MultiplicationGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        for (int i = 0; i < 5; i++)
        {
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("That is correct! Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
                score++;
            }
            else
            {
                Console.WriteLine("That is incorrect... Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
            }

            if (i != 4) continue;
            Console.WriteLine($"Game over! Your score was: {score}pts. Returning to main menu...");
            Thread.Sleep(3000);
        }
        Helpers.AddToHistory(score, GameType.Multiplication);
    }

    public static void DivisionGame(string message)
    {
        

        var score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("That is correct! Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
                score++;
            }
            else
            {
                Console.WriteLine("That is incorrect... Moving to the next question.");
                Thread.Sleep(2000);
                Console.Clear();
            }

            if (i != 4) continue;
            Console.WriteLine($"Game over! Your score was: {score}pts. Returning to main menu...");
            Thread.Sleep(3000);
        }
        Helpers.AddToHistory(score, GameType.Division);
    }
}