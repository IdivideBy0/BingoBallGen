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
            //int ctr = 100;
            ////while (ctr > 0)
            ////{
            //    Card card = new Card();
            //    card.GenerateCard();
            //    //Console.WriteLine("Card generated" + ctr);
            //    //Card.GenerateCard();
            //    ctr -= 1;
            ////}

            //foreach(var num in card.intRowB)
            //{
            //    Console.WriteLine("B" + num);
            //}
            

            Console.Write("Press Y to start the game. [D] or [d] to draw a ball." + Environment.NewLine);

            char theKey = Console.ReadKey().KeyChar;

            

            if (theKey == 'Y' || theKey == 'y')
            {

                Console.WriteLine(Environment.NewLine + "Starting a new game" + Environment.NewLine);
                //while (Ball.totalBalls != 0 && (theKey == 'D' || theKey == 'd'))
                //{
                //do
                //{
                //    theKey = Console.ReadKey(true).KeyChar;
                //    if (theKey == 'D' || theKey == 'd')
                //    {

                //        ball.CreateBall();

                //        ++ctr;

                //        Console.WriteLine("Ball number " + ctr + "--> " + ball.letter.ToString() + ball.number + " ");
                //    }
                //    //}
                //} while (Ball.totalBalls > 0);
                bool cont = false;
                do
                {
                    //theKey = Console.ReadKey().KeyChar;
                    DrawBalls();
                    Console.WriteLine("All balls drawn, play another? [Y], [N]");
                    theKey = Console.ReadKey().KeyChar;
                    Console.WriteLine(Environment.NewLine);



                    if (theKey == 'Y' || theKey == 'y')
                    {
                        cont = true;
                    }
                    else
                    {
                        cont = false;
                    }

                } while (cont);
            }

        }

        static void DrawBalls()
        {
            int ctr = 0;

            char theKey;// = Console.ReadKey().KeyChar;

            Ball ball = new Ball();

            Console.WriteLine("[D] or [d] to draw a ball.");

            do
            {
                theKey = Console.ReadKey(true).KeyChar;
                if (theKey == 'D' || theKey == 'd')
                {

                    ball.CreateBall();

                    ++ctr;

                    Console.WriteLine("Ball number " + ctr + "--> " + ball.letter.ToString() + ball.number + " ");
                }
                else if(theKey == 'q' || theKey == 'Q')
                {
                    Console.WriteLine("Do you really wish to quit? [Y], [N]");

                    theKey = Console.ReadKey(true).KeyChar;

                    if(theKey == 'Y' || theKey == 'y')
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                }
                //}
            } while (Ball.totalBalls > 0);
            
            Ball.totalBalls = 75; //reset ball counter
        }

        
    }
}
