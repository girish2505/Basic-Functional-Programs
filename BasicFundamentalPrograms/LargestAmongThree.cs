using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class LargestAmongThree
    {
        public static void ReadInput()
        {
            //Getting values of 3 numbers from user
            Console.WriteLine("Enter the value of num 1");
            //converting into integers using Convert.ToInt32
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of num2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of num3");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " is a Largest");
            }
            else if (n2 > n1 && n2 > n3)
            { 
                Console.WriteLine(n2 + " is a Largest");
            }
            else
            {
                Console.WriteLine(n3 + " is a Largest");
            }
        }
    }
}
