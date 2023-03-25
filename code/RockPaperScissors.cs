using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 3)
            {


                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input. Try Again...");
                    Console.WriteLine();
                    count++;
                    continue;
                }
                Random random = new Random();
                int computersRandomNumber = random.Next(1, 4);

                string computerMove = " ";

                switch (computersRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"The computer chose {computerMove}.");

                if (playerMove == Rock && computerMove == Scissors ||
                    playerMove == Scissors && computerMove == Paper ||
                    playerMove == Paper && computerMove == Rock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                }
                else if (playerMove == Rock && computerMove == Paper ||
                         playerMove == Scissors && computerMove == Rock ||
                         playerMove == Paper && computerMove == Scissors)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("This game was a draw.");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Too many wrong choices !!!");

        }
    }
}