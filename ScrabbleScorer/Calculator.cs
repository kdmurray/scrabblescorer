using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrabbleScorer
{
    class Calculator
    {
        static IDictionary<char, int> scrabbleLetters = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 3 },
            { 'C', 3 },
            { 'D', 2 },
            { 'E', 1 },
            { 'F', 4 },
            { 'G', 2 },
            { 'H', 4 },
            { 'I', 1 },
            { 'J', 8 },
            { 'K', 5 },
            { 'L', 1 },
            { 'M', 3 },
            { 'N', 1 },
            { 'O', 1 },
            { 'P', 3 },
            { 'Q', 10 },
            { 'R', 1 },
            { 'S', 1 },
            { 'T', 1 },
            { 'U', 1 },
            { 'V', 4 },
            { 'W', 4 },
            { 'X', 8 },
            { 'Y', 4 },
            { 'Z', 10 },
            { ' ', 0 }
        };

        public static int WordValue(string word)
        {
            int score = 0;
            int multiplier = 1;

            char[] letters = word.ToUpper().ToCharArray();

            foreach (char c in letters)
            {
                if (c.ToString() == "2")
                {
                    multiplier = 2;
                }
                if (c.ToString() == "3")
                {
                    multiplier = 3;
                }

                if (scrabbleLetters.ContainsKey(c))
                {
                    score += multiplier * scrabbleLetters[c];
                    multiplier = 1;
                }
            }

            return score;
        }
    }
}
