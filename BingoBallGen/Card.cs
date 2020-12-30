using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoBallGen
{
    class Card
    {
        
        private List<int> rowB = new List<int>();
        private List<int> rowI = new List<int>();
        private List<int> rowN = new List<int>();
        private List<int> rowG = new List<int>();
        private List<int> rowO = new List<int>();

        public int[] intRowB;
        public int[] intRowI;
        public int[] intRowN;
        public int[] intRowG;
        public int[] intRowO;

        public void GenerateCard()
        {

            //while (amt > 0)
            {
                //Console.WriteLine("Generating Card...");

                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                for (int i = 0; i < 5; i++)
                {
                    int tmp = rnd.Next(1, 15);

                    if (!rowB.Contains(tmp))
                    {
                        //Console.WriteLine("B" + tmp);
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
                        //Console.WriteLine("I" + tmp);
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
                    //if (i == 2)
                    //    Console.WriteLine("Free");

                    if (!rowN.Contains(tmp))
                    {
                        //Console.WriteLine("N" + tmp);
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
                        //Console.WriteLine("G" + tmp);
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
                        //Console.WriteLine("O" + tmp);
                        rowO.Add(tmp);
                    }
                    else
                    {
                        i -= 1; // deincrement counter and try again
                    }

                }
                Console.WriteLine(Environment.NewLine);
                //amt -= 1;
                intRowB = rowB.ToArray();
                intRowI = rowI.ToArray();
                intRowN = rowN.ToArray();
                intRowG = rowG.ToArray();
                intRowO = rowO.ToArray();
            }
        }
    }
}
