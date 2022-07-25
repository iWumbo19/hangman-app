using System;
using System.Collections.Generic;
using System.Text;

namespace hangman_app
{
    internal static class Game
    {
        private static string[] _words;
        private static string[] _lines;
        private static string _curWord;
        private static bool[] _solved;
        private static bool _gameStarted = false;
        private static int _misses;
        private static List<char> _guesses;

       
        internal static void UpdateWords(string[] nuWords)
        {
            if (nuWords == null) throw new ArgumentNullException(nameof(nuWords));
            _words = nuWords;
        }
        
        private static string GetRandomWord()
        {
            Random random = new Random();
            return _words[random.Next(0, _words.Length)];
        }

        private static int DecideMisses(string word)
        {
            switch (word.Length)
            {
                case int n when (n >= 1 && n <= 5):
                    return 5;
                case int n when (n >= 6 && n <= 8):
                    return 6;
                case int n when (n > 8):
                    return 7;
                default:
                    return 3;
            }
        }

        private static void UpdateSolved(int[] indicies)
        {
            foreach (var index in indicies)
            {
                _solved[index] = true;
            }
        }

        private static void UpdateCurrentWord(string word)
        {
            if (word == null) throw new ArgumentNullException(nameof(word));
            _curWord = word;
            ClearSolved();
        }

        private static void ClearSolved()
        {
            _solved = new bool[_curWord.Length];
            for (int i = 0; i < _solved.Length; i++)
            {
                _solved[i] = false;
            }
        }

        public static int[] GetCharIndicies(char c)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < _curWord.Length; i++)
            {
                if (_curWord[i] == c) output.Add(i);
            }
            return output.ToArray();
        }

        public static bool IsSolved()
        {
            foreach (bool solved in _solved)
            {
                if (!solved) return false;
            }
            return true;
        }

        public static int[] GuessLetter(char c)
        {
            int[] indicies = GetCharIndicies(c);
            if (indicies.Length == 0)
            {
                _misses--;
                if(Failed()) _gameStarted = false;
                return null;
            }
            UpdateSolved(indicies);
            return indicies;
        }

        public static bool IsOngoing()
        {
            return _gameStarted;
        }

        public static char[] Guesses()
        {
            return _guesses.ToArray();
        }

        public static string Start()
        {
            string word = GetRandomWord();
            UpdateCurrentWord(word);
            _misses = DecideMisses(word);
            _guesses = new List<char>();
            _gameStarted = true;
            return word;
        }

        public static void UpdateLines(string[] nuLines)
        {
            if (nuLines == null) throw new ArgumentNullException(nameof(nuLines));
            _lines = nuLines;
        }

        public static bool Failed()
        {
            return _misses == 0 ? true : false;
        }

        public static int MissesLeft()
        {
            return _misses;
        }

        public static string GetCurrentWord()
        {
            return _curWord;
        }
    }
}
