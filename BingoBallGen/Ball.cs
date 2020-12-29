using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoBallGen
{
    class Ball
    {
        public static int totalBalls = 75;

        private List<int> bBalls = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        private List<int> iBalls = new List<int> { 16, 17, 17, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        private List<int> nBalls = new List<int> { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };
        private List<int> gBalls = new List<int> { 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };
        private List<int> oBalls = new List<int> { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 };

        private List<char> letters = new List<char> { 'B', 'I', 'N', 'G', 'O' };
        public char letter { get; set; }
        public int number { get; set; }

        public Ball CreateBall()
        {
            if (totalBalls > 0)
            {
                letter = GetLetter(); // get a random letter

                List<int> activeNumList = new List<int>();

                //GetNumber from the appropriate list
                switch (letter)
                {
                    case 'B':
                        activeNumList = bBalls;
                        number = GetNumber(activeNumList);
                        break;
                    case 'I':
                        activeNumList = iBalls;
                        number = GetNumber(activeNumList);
                        break;
                    case 'N':
                        activeNumList = nBalls;
                        number = GetNumber(activeNumList);
                        break;
                    case 'G':
                        activeNumList = gBalls;
                        number = GetNumber(activeNumList);
                        break;
                    case 'O':
                        activeNumList = oBalls;
                        number = GetNumber(activeNumList);
                        break;
                }

                // In case we pick a letter that has exhausted all ball numeric values, repick a new letter.

                if (number != 0)
                {
                    // remove the ball from the list
                    Removeball(activeNumList, number);

                    totalBalls -= 1; //reduce the number of balls in the ball pit by one
                }
                else
                {
                    //remove ball letter from the list

                    letters.Remove(letter);

                    // create a new ball with a valid value

                    CreateBall();
                }
            }

            return this;
        }

        private char GetLetter()
        {

 
                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                int position = rnd.Next(0, letters.Count);
            

            return letters[position];
        }

        private int GetNumber(List<int> ballNumbers)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            if (ballNumbers.Count != 0)
            {
                int ballNum = rnd.Next(0, ballNumbers.Count());
                return ballNumbers[ballNum];
            }
            else
            {
                return 0;
            }
        
        }

        private void Removeball(List<int> ballNumbers, int ballnum)
        {
            ballNumbers.Remove(ballnum);
        }

    }
}
