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
            int userInput = 0;
            while (userInput != 1 && userInput != 2 && userInput != 3 && userInput != 4 && userInput != 5)
            {
                Console.WriteLine($"Please choose a Gesture. Press 1 for {gestures[0]} Press 2 for {gestures[1]} Press 3 for {gestures[2]} Press 4 for {gestures[3]} Press 5 for {gestures[4]}");
                    userInput = Convert.ToInt32(Console.ReadLine());
            }
            

            if (userInput == 1)
            {
                chosenGesture = gestures[0];
            }
           else if(userInput == 2)
            {
                chosenGesture = gestures[1];
            }
         
            else if(userInput == 3)
            {
                chosenGesture = gestures[2];
            }

            else if(userInput == 4)
            {
                chosenGesture = gestures[3];
            }

            else if(userInput == 5)
            {
                chosenGesture = gestures[4];
            }



            
        }
    }
}
