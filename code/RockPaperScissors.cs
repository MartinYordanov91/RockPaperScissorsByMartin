            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

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
                Console.WriteLine("Invalid Input. Try Again...");
                return;
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
            Console.WriteLine($"The computer chose {computerMove}.");

            if (playerMove == Rock && computerMove == Scissors ||
                playerMove == Scissors && computerMove == Paper ||
                playerMove == Paper && computerMove == Rock)
            {
                Console.WriteLine("You win.");
            }
            else if (playerMove == Rock && computerMove == Paper ||
                     playerMove == Scissors && computerMove == Rock ||
                     playerMove == Paper && computerMove == Scissors)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }