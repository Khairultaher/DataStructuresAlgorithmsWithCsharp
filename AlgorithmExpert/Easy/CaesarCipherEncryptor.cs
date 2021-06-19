using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public static class CaesarCipherEncryptor
    {
        // O(n) time | O(n) space
        public static string Encrypt(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = GetNewLetter(str[i], key);
            }
            return new string(newLetters);
        }
        public static char GetNewLetter(char letter, int key)
        {
            int newKey = key % 26;
            int newLetterCode = letter + newKey;
            return newLetterCode <= 122 ? (char)newLetterCode
                                        : (char)(96 + newLetterCode % 122);
        }

        // Encrypts text using a shift ods
        public static StringBuilder Encrypt1(String text, int s)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)text[i] + s - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    char ch = (char)(((int)text[i] + s - 97) % 26 + 97);
                    result.Append(ch);
                }
            }
            return result;
        }
    }
}
