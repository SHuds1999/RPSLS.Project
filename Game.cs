using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Game
    {

        Player player1;
        Player player2;
  
        public Game()
        {
          

        }


        public void SelectGameMode()
        {
            int userInput = 0;

            while( userInput != 1 && userInput != 2 )//condition to check if true, if true, stay in while loop)
            {

                Console.WriteLine("What Game Mode Would You Like To Play. Type 1 for Single Player or Type 2 for MultiplayerPlayer.");
                userInput = Convert.ToInt32(Console.ReadLine());
            
            }


                if (userInput == 1)
                {
                    player1 = new Human();
                    player2 = new ComputerAi();
                }

                else if (userInput == 2)
                {
                    player1 = new Human();
                    player2 = new Human();
                }
            
  
        }







 

        public void CompareGestures()
        {

            player1.ChooseGesture();
            player2.ChooseGesture();

            if (player1.chosenGesture == "Rock" && player2.chosenGesture == "Scissors")
            {

                Console.WriteLine($"Player 1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Rock Crushes Paper. Player 1 wins ");

                player1.score++;

            }

            else if (player1.chosenGesture == "Scissors" && player2.chosenGesture == "Paper")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Scissors cuts Paper. Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Lizard" && player2.chosenGesture == "Spock")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Lizard poisons Spock.  Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Spock" && player2.chosenGesture == "Scissors")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Spock smashes Scissors.  Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Scissors" && player2.chosenGesture == "Lizard")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Scissors decapitates Lizard.  Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Lizard" && player2.chosenGesture == "Paper")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Lizard eats Paper. Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Paper" && player2.chosenGesture == "Spock")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Paper disproves Spock. Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Paper" && player2.chosenGesture == "Rock")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Paper covers Rock. Player 1 wins ");

                player1.score++;

            }

            else if (player1.chosenGesture == "Rock" && player2.chosenGesture == "Lizard")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Rock crushes Lizard. Player 1 wins ");

                player1.score++;

            }


            else if (player1.chosenGesture == "Spock" && player2.chosenGesture == "Rock")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Spock vaporizes Rock. Player 1 wins ");

                player1.score++;

            }

            else
            {
                Console.WriteLine("Player 2 Wins");
                player2.score++;
            }


        }

        public void DisplayWinner()
        {
            if(player1.score == 3)
            {
                Console.WriteLine("Player1 Wins!");
            }


            else if(player2.score == 3)
            {
                Console.Write("Player2 Wins!");
            }



        }

        public void RunGame()
        {
            SelectGameMode();
             
            while(player1.score < 3 && player2.score < 3)
            {
                CompareGestures();
            }

            DisplayWinner();

        }


    }



}
