using System;

namespace PlayWithStrings
{
    class Program
    {
        static void Main()
        {
            string text = "this is a shitty piggy chop";
            // var repeated = StringsProblemSolutions.GetDuplicateCharacters(text.ToLower());
            // Console.WriteLine("Repeated characters are: {0}", string.Join(", ", repeated));

            // string first = "i love ety";
            // string second = "love i ety";

            // Console.WriteLine("Are strings anagrams ? {0}", StringsProblemSolutions.AreAnagrams(first, second));

            // string text = "890098";
            // Console.WriteLine("Is the string a palindrome ? {0}", StringsProblemSolutions.IsPalindrome(text));

            // string rep = "repeated text";
            // Console.WriteLine("Repeated characters are: {0}", StringsProblemSolutions.FirstNonRepeatedCharacter(rep));

            // Console.WriteLine(StringsProblemSolutions.AreDigits("87687999"));

            // var duplicate = StringsProblemSolutions.FindDuplicateChars(first);
            // Console.WriteLine("Duplicate characters are: {0}", string.Join(", ", duplicate));

            Console.WriteLine(StringsProblemSolutions.CharacterOccurance(text, 'p'));

            text = "abc";
            Console.WriteLine("Possible permutation numbers is: {0}", StringsProblemSolutions.PossiblePermutationCount(text));
        }
    }
}
