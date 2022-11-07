using System.Text;

namespace PlayWithStrings
{
    
    public class StringsProblemSolutions
    {
        
        public static string ReverseWords(string text)
        {
            if (text == null) throw new ArgumentException("Null is not a valid  Argument for this operation");
            if (text == "") return "";
            if (text.Length == 1) return text;
            
            List<string> container = text.Split(' ').ToList();
            List<string> buffer = new();
            
            foreach (string word in container)
            {
                buffer.Add(Reverse(word));
            }

            return string.Join(" ", buffer);
        }
        public static int PossiblePermutationCount(string text)
        {
            return (int)Math.Pow(2, text.Length);
        }
        public static int CharacterOccurance(string text, char character)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    count++;
                }
            }
            return count;
        }
        public static bool AreRotations(string  first, string second)
        {
            return (first.Length == second.Length) && ((first + second).IndexOf(second) != -1);
        }
        public static List<char> FindDuplicateChars(string text)
        {
            List<char> result = new();
            if (text.Length == 0)
            {
                return result;
            }

            char[] chars = text.ToCharArray();
            for (int inner = 0; inner < chars.Length; inner++)
            {
                for (int outer = inner + 1; outer < chars.Length; outer++)
                {
                    if (chars[inner] == chars[outer])
                    {
                        result.Add(chars[inner]);
                    }
                }
            }
            return result;
        }
        public static bool AreDigits(string text)
        {
            if (text == null) return false;

            foreach (char ch in text)
            {
                if (!char.IsDigit(ch)) return false;
            }
            return true;
        }
        public static string Reverse(string text)
        {
            Stack<char> buffer = new();
            foreach (char ch in text)
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
            Dictionary<char, int> buffer = new();
            foreach (char ch in text)
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
            foreach (char ch in text)
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
            foreach (char character in first)
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
            foreach (char character in second)
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
            foreach (KeyValuePair<char, int> character in firstDictionary)
            {
                if (!secondDictionary.ContainsKey(character.Key) ||
                    character.Value != secondDictionary[character.Key])
                {
                    return false;
                }
            }
            return true;
        }

        public static int CountConsonants(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (IsConsonant(text[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static int CountVowels(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    ++count;
                }
            }
            return count;
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
            foreach(KeyValuePair<char, int> key_value in buffer)
            {
                if (key_value.Value > 1)
                {
                    result.Add(key_value.Key);
                }
            }
            return result;
        }

        private static bool IsConsonant(char letter)
        {
            letter = Char.ToUpper(letter);
            return !(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U') && letter >= 65 && letter <= 90;
        }
        private static bool IsVowel(char letter)
        {
            letter = Char.ToUpper(letter);
            return (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U');
        }
    }
}