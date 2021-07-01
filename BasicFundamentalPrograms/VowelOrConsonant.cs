using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFundamentalPrograms
{
    class VowelOrConsonant
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a letter");
            string chr = Console.ReadLine();
            if (chr == "a" || chr == "e" || chr == "i" || chr == "o" || chr == "u" || chr == "A" || chr == "E" || chr == "I" || chr == "O" || chr == "U")
            {
                Console.WriteLine(chr+" is a Vowel");
            }
            else
            {
                Console.WriteLine(chr + " is a Consonant");
            }

        }

    }
}
