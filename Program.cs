using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeWords();
            Application.Run(new HangmanUI());
        }

        static void InitializeWords()
        {
            string[] words = System.IO.File.ReadAllLines("wordlist.txt");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Split()[1];
            }
            Game.UpdateWords(words);
        }
    }
}
