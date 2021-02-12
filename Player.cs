using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    abstract class Player
    {

        //member variables (what should each player have?

        public List<string> gestures;
        public int score;
        public string chosenGesture;

        public Player()
        {
            gestures = new List<string>();
            score = 0;


            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }


        public abstract void ChooseGesture();


    }




}
