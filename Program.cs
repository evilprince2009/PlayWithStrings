using System;

namespace PlayWithStrings
{
    class Program
    {
        static void Main()
        {
            string text = "You will never know how much I loved you , infact never. Truth is I loved you so much & I still do.";
            Console.WriteLine(StringsProblemSolutions.ReverseWords(text));
            Console.WriteLine("Total vowels: {0}", StringsProblemSolutions.CountVowels(text));

            string cons = "abcd";
            Console.WriteLine("Total consonant: {0}", StringsProblemSolutions.CountConsonants(cons));
        }
    }
}
