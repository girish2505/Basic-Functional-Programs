using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class PowerOfTwo
    {
        public static void FindPowerOfTwo()
        {
            Console.WriteLine("Enter the power");
            int maxPower = Convert.ToInt32(Console.ReadLine());
            printTableOfTwo(maxPower);
        }
        private static void printTableOfTwo(int power)
        {
            Console.Write(" [ ");
            for(int i=1; i<=power;i++)
            {
                Console.Write(Math.Pow(2, i) + " ");
            }
            Console.WriteLine(" ] ");
        }
    }
}
