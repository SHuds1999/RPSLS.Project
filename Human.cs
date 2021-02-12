using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Human : Player
    {
        
        



        public Human()
        {
        

        }

        public override void ChooseGesture()
        {

            //user input 
            int userInput;
            Console.WriteLine("Please Choose A Gesture" + gestures[0] + gestures[1] + gestures[2] + gestures[3] + gestures[4]);
            userInput = Convert.ToInt32(Console.ReadLine());
            chosenGesture = gestures[userInput];
        }
    }
}
