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
        int score;
        public string chosenGesture;

        public Player()
        {
            gestures = new List<string>();
            score = 0;


            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("sissors");
            gestures.Add("lizard");
            gestures.Add("spock");



        }


        public abstract void ChooseGesture();

        



























    }




}
