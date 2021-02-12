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
            Console.WriteLine($"Please choose a Gesture. Press 0 for {gestures[0]} Press 1 for {gestures[1]} Press 2 for {gestures[2]} Press 3 for {gestures[3]} Press 4 for {gestures[4]}");
            userInput = Convert.ToInt32(Console.ReadLine());
            chosenGesture = gestures[userInput];
        }
    }
}
