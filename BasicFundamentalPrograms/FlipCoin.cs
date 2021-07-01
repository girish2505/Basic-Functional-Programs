using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            //taking input from the user...
            Console.WriteLine("please enter the number to find number of times to flip coin");
            // Converting the input to integer by using ToInt32 ....
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            FindPercentage(numberOfTimes);
        }
        private static void FindPercentage(int numberOfTimes)
        {
            int tail = 0, head = 0;
            //initalization of random class....
            Random random = new Random();
            for(int i=0; i<numberOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            Console.WriteLine("Number of tails "+tail+" out of "+numberOfTimes);
            Console.WriteLine("Number of heads " + head + " out of " + numberOfTimes);
            double tailPercentage = (double)tail / numberOfTimes * 100;
            double headPercentage = (double)head / numberOfTimes * 100;
            Console.WriteLine("Tail percentage "+tailPercentage);
            Console.WriteLine("Head percentage " +headPercentage);
        }
    }
}
