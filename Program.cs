using System;

namespace PlayWithStrings
{
    class Program
    {
        static void Main()
        {
            string text = "this is a shitty piggy chop";
            var repeated = StringsProblemSolutions.GetDuplicateCharacters(text.ToLower());
            Console.WriteLine("Repeated characters are: {0}", string.Join(", ", repeated));
        }
    }
}
