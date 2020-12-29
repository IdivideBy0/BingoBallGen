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
            GenerateCard(100);
            Console.Write("Press Y to start the game. [D] or [d] to draw a ball." + Environment.NewLine);

            char theKey = Console.ReadKey().KeyChar;

            //Ball ball = new Ball();

            int ctr = 0;

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

        static void GenerateCard(int amt)
        {

            while (amt > 0)
            {
                Console.WriteLine("Generating Card...");

                List<int> rowB = new List<int>();
                List<int> rowI = new List<int>();
                List<int> rowN = new List<int>();
                List<int> rowG = new List<int>();
                List<int> rowO = new List<int>();


                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                for (int i = 0; i < 5; i++)
                {
                    int tmp = rnd.Next(1, 15);

                    if (!rowB.Contains(tmp))
                    {
                        Console.WriteLine("B" + tmp);
                        rowB.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);

                for (int i = 0; i < 5; i++)
                {
                    int tmp = rnd.Next(16, 30);

                    if (!rowI.Contains(tmp))
                    {
                        Console.WriteLine("I" + tmp);
                        rowI.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);

                for (int i = 0; i < 4; i++)
                {
                    int tmp = rnd.Next(31, 45);
                    if (i == 2)
                        Console.WriteLine("Free");

                    if (!rowN.Contains(tmp))
                    {
                        Console.WriteLine("N" + tmp);
                        rowN.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);

                for (int i = 0; i < 5; i++)
                {
                    int tmp = rnd.Next(46, 60);

                    if (!rowG.Contains(tmp))
                    {
                        Console.WriteLine("G" + tmp);
                        rowG.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);

                for (int i = 0; i < 5; i++)
                {
                    int tmp = rnd.Next(61, 75);

                    if (!rowO.Contains(tmp))
                    {
                        Console.WriteLine("O" + tmp);
                        rowO.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);
                amt -= 1;
            }
        }
    }
}
