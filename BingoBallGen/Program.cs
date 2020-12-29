using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoBallGen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Press Y to start the game. [D] or [d] to draw a ball." + Environment.NewLine);

            char theKey = Console.ReadKey().KeyChar;
            
                Ball ball = new Ball();

                int ctr = 0;

                if (theKey == 'Y' || theKey == 'y')
                {
                
                Console.WriteLine(Environment.NewLine + "Starting a new game" + Environment.NewLine);
                //while (Ball.totalBalls != 0 && (theKey == 'D' || theKey == 'd'))
                //{
                    do
                    {
                        theKey = Console.ReadKey(true).KeyChar;
                        if (theKey == 'D' || theKey == 'd')
                        {

                            ball.CreateBall();

                            ++ctr;

                            Console.WriteLine("Ball number " + ctr + "--> " + ball.letter.ToString() + ball.number + " ");
                        }
                        //}
                    } while (Ball.totalBalls > 0);
                }

        }
    }
}
