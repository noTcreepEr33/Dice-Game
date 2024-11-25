using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;
            int p1s = 0;
            int p2s = 0;
            Random random = new Random();
            for (int j = 0; j<10; j++)
            {
                Console.WriteLine("Welcome to DiceGame!");
                Console.WriteLine("Please enter Player one name :");
                string? playerOneName = Console.ReadLine();
                Console.WriteLine("Please enter Player two name :");
                string? playerTwoName = Console.ReadLine();
                var round = 1;
                for (var i = 0; i < 10; i++)
                {
                    
                    Console.WriteLine("Round" + round);
                    Console.WriteLine();
                    p1 = random.Next(1, 11);
                    p1s = p1s + p1;
                    Console.WriteLine(playerOneName + " scored : " + p1);
                    Console.WriteLine("Rolling Dice!");
                    Task.Delay(1000).Wait();
                    p2 = random.Next(1, 11);
                    p2s = p2s + p2;
                    Console.WriteLine(playerTwoName + " scored : " + p2);
                    Console.WriteLine("Press any key to continue ...");
                    Console.ReadKey();
                    round++;
                    Console.WriteLine();
                }

                if (p1s < p2s)
                {
                    Console.WriteLine(playerTwoName + " Win!");
                    Console.WriteLine(playerOneName + " Total scored :" + p1s);
                    Console.WriteLine(playerTwoName + " Total scored : " + p2s);
                }
                else if (p1s > p2s)
                {
                    Console.WriteLine(playerOneName + " Win!");
                    Console.WriteLine(playerOneName + "Total scored :" + p1s);
                    Console.WriteLine(playerTwoName + " Total scored : " + p2s);
                }
                else
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine(playerOneName + "Total scored :" + p1s);
                    Console.WriteLine(playerTwoName + " Total scored : " + p2s);
                }

                j = 0;
            }
            
        }
    }
}