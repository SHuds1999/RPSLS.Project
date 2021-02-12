using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class ComputerAi : Player
    {
        Random randChoice;
        


        public ComputerAi()
        {
            randChoice = new Random();

 
        }

        public override void ChooseGesture()
        {
            //randomly select gesture from gesture options to assing to chosen gesture
            int randomNumber = randChoice.Next(gestures.Count);
            chosenGesture = gestures[randomNumber];
        }
    }
}
