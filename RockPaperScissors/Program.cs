using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            int compChoice;
            Random random = new Random();
            int userScore = 0;
            int compScore = 0;
            do
            {
                Console.WriteLine("Enter Rock, Paper, or Scissors");
                Console.WriteLine();
                Console.WriteLine("Score| User: " + userScore + " - Computer: " + compScore);
                Console.WriteLine();
                Console.WriteLine("Type stop to exit");
                Console.WriteLine();
                userChoice = Console.ReadLine()?.ToUpper();
                compChoice = random.Next(1,4);

                Console.WriteLine();
                if (userChoice == "ROCK" && compChoice == 1)
                {
                    Console.WriteLine("Computer chose rock");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("It's a tie");
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (userChoice == "ROCK" && compChoice == 2)
                {
                    Console.WriteLine("Computer chose paper");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("Computer wins");
                    compScore++;
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (userChoice == "ROCK" && compChoice == 3)
                {
                    Console.WriteLine("Computer chose scissors");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("You win!!");
                    userScore++;
                    Console.WriteLine();
                    Console.ReadKey();

                }

                if (userChoice == "PAPER" && compChoice == 1)
                {
                    Console.WriteLine("Computer chose rock");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("You win!!");
                    userScore++;
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (userChoice == "PAPER" && compChoice == 2)
                {
                    Console.WriteLine("Computer chose paper");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("It's a tie");
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (userChoice == "PAPER" && compChoice == 3)
                {
                    Console.WriteLine("Computer chose scissors");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("Computer wins");
                    compScore++;
                    Console.WriteLine();
                    Console.ReadKey();

                }

                if (userChoice == "SCISSORS" && compChoice == 1)
                {
                    Console.WriteLine("Computer chose rock");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("Computer wins");
                    compScore++;
                    Console.WriteLine();
                    Console.ReadKey();

                }

                else if (userChoice == "SCISSORS" && compChoice == 2)
                {
                    Console.WriteLine("Computer chose paper");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("You win!!");
                    userScore++;
                    Console.WriteLine();
                    Console.ReadKey();
                }

                else if (userChoice == "SCISSORS" && compChoice == 3)
                {
                    Console.WriteLine("Computer chose scissors");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("It's a tie");
                    Console.WriteLine();
                    Console.ReadKey();
                }

                else if (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS" && userChoice != "STOP")
                {
                    Console.WriteLine("Invalid input, please try again");
                    Console.WriteLine();
                }

            }
            while (userChoice != "STOP" || userChoice != "EXIT" || userChoice != "END" || userChoice != "1");
        }
    }
}