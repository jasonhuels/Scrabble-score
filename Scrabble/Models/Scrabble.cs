using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble
{
    public class Scrabble
    {
        public static char[] OnePoint = new char[] {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
        public static char[] TwoPoint = new char[] {'d', 'g'};
        public static char[] ThreePoint = new char[] {'b', 'c', 'm', 'p'};
        public static char[] FourPoint = new char[] {'f', 'h', 'v', 'w', 'y'};
        public static char[] FivePoint = new char[] {'k'};
        public static char[] EightPoint = new char[] {'j', 'x'};
        public static char[] TenPoint = new char[] {'q', 'z'};
        public static Dictionary<char[], int> LetterValues = new Dictionary<char[], int>()
        {
            {OnePoint, 1},
            {TwoPoint, 2},
            {ThreePoint, 3},
            {FourPoint, 4},
            {FivePoint, 5},
            {EightPoint, 8},
            {TenPoint, 10}

        };

        public static int ScrabbleScore(string word)
        {
            int score = 0;
            for(int i=0; i<word.Length; i++)
            {
                for(int j=0; j<LetterValues.Count; j++)
                {
                    if(Array.IndexOf(LetterValues.ElementAt(j).Key, word[i]) > -1)
                    {
                        score += LetterValues.ElementAt(j).Value;
                    }
                }
            }
            return score;
        }
    }
}
