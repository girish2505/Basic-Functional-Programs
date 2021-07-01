using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class HarmonicNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the nth harmonic number");
            int hormonic = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber harmonicNumber = new HarmonicNumber();
            harmonicNumber.FindHarmonicNumber(hormonic);
        }
        private void FindHarmonicNumber(int harmonic)
        {
            double sum = 0;
            for(int i=1; i<=harmonic;i++)
            {
                sum = sum + (double)1 / i;
            }
            Console.WriteLine(harmonic+"th harmonic value = "+sum);
        }
    }
}
