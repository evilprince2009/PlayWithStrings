using System.Collections.Generic;

namespace PlayWithStrings
{
    public class StringsProblemSolutions
    {
        public static List <char> GetDuplicateCharacters(string text)
        {
            IDictionary <char, int> buffer = new Dictionary <char, int>();
            foreach(char ch in text)
            {
                if (buffer.ContainsKey(ch))
                {
                    buffer[ch]++;
                }
                else
                {
                    buffer[ch] = 1;
                }
            }

            List <char> result = new();
            foreach(var key_value in buffer)
            {
                if (key_value.Value > 1)
                {
                    result.Add(key_value.Key);
                }
            }
            return result;
        }
    }
}