using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    class AIOpponent
    {
        //memory
        public int lastGuess { get; set; }
        public int currGuess { get; set; }
        public int randomInt { get; set; }

        //states
        public bool isWarmer { get; set; }
        public bool isColder { get; set; }
        public bool isCorrect { get; set; }
        public bool isTooHigh { get; set; }
        public bool isTooLow { get; set; }

        public AIOpponent(int initialGuess)
        {
            lastGuess = initialGuess;
            currGuess = initialGuess;
            randomInt = generateRandomNumber();
            isWarmer = false;
            isColder = false;
            isCorrect = false;
            isTooHigh = false;
            isTooLow = false;
        }
        public AIOpponent()
        {
            lastGuess = 0;
            currGuess = 0;
            randomInt = generateRandomNumber();
            isWarmer = false;
            isColder = false;
            isCorrect = false;
            isTooHigh = false;
            isTooLow = false;
        }

        public int generateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }

        public void giveChoice(int userChoice)
        {
            //set memory
            lastGuess = currGuess;
            currGuess = userChoice;

            //get bearings
            int lastDistance = Math.Abs(randomInt - lastGuess);
            int currDistance = Math.Abs(randomInt - currGuess);

            //set states
            if (lastDistance < currDistance)
            {
                //went away
                isWarmer = false;
                isColder = true;

                //is it correct now?
                if (currGuess == randomInt)
                    isCorrect = true;
                else
                    isCorrect = false;
            }
            else if (lastDistance > currDistance)
            {
                //came closer
                isWarmer = true;
                isColder = false;

                //is it correct now?
                if (currGuess == randomInt)
                    isCorrect = true;
                else
                    isCorrect = false;
            }
            else
            {
                //went nowhere?
                isWarmer = false;
                isColder = false;
            }

            if (currGuess > randomInt)
            {
                // current guess is too high
                isTooHigh = true;
                isTooLow = false;
            }
            else if (currGuess < randomInt)
            {
                // current guess is too low
                isTooHigh = false;
                isTooLow = true;
            }
            else
            {
                // current guess is correct
                isTooHigh = false;
                isTooLow = false;
            }
        }//end giveChoice
    }//end AIOpponent

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}