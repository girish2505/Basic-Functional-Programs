using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class OddOrEven
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine(num + " is even number...");
            }
            else
            {
                Console.WriteLine(num + " is odd number...");
            }
        }
    }
}
