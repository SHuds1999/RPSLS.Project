using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Game
    {

        Player player1 = new Human();
        Player player2 = new ComputerAi();
        
       

        public Game()
        {
            
            
            
            

        }


        




        public void CompareGestures()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();

            if( player1.chosenGesture == "Rock" &&  player2.chosenGesture == "Scissors" )
            {

                Console.WriteLine($"Player 1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Rock Crushes Paper. Player 1 wins ");

                player1.score++;

            }

            else if ( player1.chosenGesture == "Scissors" && player2.chosenGesture == "Paper")
            {

                Console.WriteLine($"Player1 chose {player1.chosenGesture} Player 2 chose {player2.chosenGesture}. Scissors cuts Paper. Player 1 wins ");

                player1.score++;

            }













        }

        
























    }



}
