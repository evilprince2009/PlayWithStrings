using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PlayWithStrings
{
    public class StringsProblemSolutions
    {
        public static string Reverse(string text)
        {
            Stack<char> buffer = new();
            foreach (var ch in text)
            {
                buffer.Push(ch);
            }

            StringBuilder result = new();
            while (buffer.Count != 0)
            {
                result.Append(buffer.Pop());
            }

            return result.ToString();
        }
        public static char FirstNonRepeatedCharacter(string text)
        {
            var buffer = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (!buffer.ContainsKey(ch))
                {
                    buffer[ch] = 1;
                }
                else
                {
                    buffer[ch]++;
                }
            }
            foreach (var ch in text)
            {
                if (buffer[ch] == 1)
                {
                    return ch;
                }
            }
            return char.MinValue;
        }
        public static bool IsPalindrome(string text)
        {
            string buffer = text.ToLower();
            int front = 0;
            int rear = buffer.Length - 1;
            while (front < rear)
            {
                if (buffer[front] != buffer[rear])
                {
                    return false;
                }
                front++;
                rear--;
            }
            return true;
        }
        public static bool AreAnagrams(string first, string second)
        {
            if (first == null || second == null)
            {
                return false;
            }
            if (first.Length != second.Length)
            {
                return false;
            }
            IDictionary <char, int> firstDictionary = new Dictionary<char, int>();
            IDictionary <char, int> secondDictionary = new Dictionary<char, int>();
            foreach (var character in first)
            {
                if (firstDictionary.ContainsKey(character))
                {
                    firstDictionary[character]++;
                }
                else
                {
                    firstDictionary.Add(character, 1);
                }
            }
            foreach (var character in second)
            {
                if (secondDictionary.ContainsKey(character))
                {
                    secondDictionary[character]++;
                }
                else
                {
                    secondDictionary.Add(character, 1);
                }
            }
            foreach (var character in firstDictionary)
            {
                if (!secondDictionary.ContainsKey(character.Key) ||
                    character.Value != secondDictionary[character.Key])
                {
                    return false;
                }
            }
            return true;
        }
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