using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class SwapingTwoNumbers
    {
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter the value of num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping");
            Console.WriteLine("Num 1 = " + num1);
            Console.WriteLine("Num 2 = " + num2);

            //Swapping two numbers without using 3rd variable
            //consider num1 =3 num2=4 (before swap)
            num1 = num1 * num2; //num1 = 3*4 =12
            num2 = num1 / num2; //num2 = 12/4 =3
            num1 = num1 / num2; //num1 = 12/3 =4

            Console.WriteLine("After Swapping");
            Console.WriteLine("Num 1 = " + num1);
            Console.WriteLine("Num 2 = " + num2);

        }
    }
}
