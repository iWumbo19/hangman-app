using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_app
{
    public partial class HangmanUI : Form
    {
        public HangmanUI()
        {
            InitializeComponent();
            ResetLayout();
        }

        // GUESSING CHAIN
        private void Select_Letter(object sender, MouseEventArgs e)
        {
            if (!Game.IsOngoing()) return;
            Label guess = (Label)sender;
            ProcessGuess(Char.ToLower(guess.Text[0]));
            guess.BackColor = Color.DarkKhaki;
        }

        private void ProcessGuess(char c)
        {
            if (!Game.IsOngoing()) return;
            int[] letters = Game.GuessLetter(c);
            if (letters != null) // Matches in word found
            {
                string nuWord = UpdateDispWord(letters, c);
                ProcessDispWord(nuWord);
            }
            UpdateMissesLabel();
            

            if (Game.Failed())
                GameFailed();
            if (Game.IsSolved())
                GameSuccess();
            
        }

        private void ProcessDispWord(string word)
        {
            string output = "";
            for (int i = 0; i < word.Length; i++)
            {
                output += $"{word[i]} ";
            }
            WordDisplay.Text = output;
        }

        private string UpdateDispWord(int[] indicies, char c)
        {
            string[] word = WordDisplay.Text.Split();
            for (int i = 0; i < indicies.Length; i++)
            {
                word[indicies[i]] = c.ToString();
            }
            return String.Join("", word);
        }

        private void UpdateMissesLabel()
        {
            MissesLabel.Text = $"Misses Remaining: {Game.MissesLeft()}";
        }


        
        // EVENTS
        private void Mouse_Enter_Letter(object sender, EventArgs e)
        {
            if (!Game.IsOngoing()) return;
            Label hover = (Label)sender;
            if (hover.BackColor != Color.DarkKhaki) 
                hover.BackColor = Color.DarkGray;
        }

        private void Mouse_Leave_Letter(object sender, EventArgs e)
        {
            if (!Game.IsOngoing()) return;
            Label hover = (Label)sender;
            if (hover.BackColor != Color.DarkKhaki)
                hover.BackColor = Label.DefaultBackColor;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            string newWord = Game.Start();
            string dispWord = "";
            for (int i = 0; i < newWord.Length; i++)
            {
                dispWord += '_';
            }
            ResetLayout();
            ProcessDispWord(dispWord);
            OutputWindow.Text = "";
            UpdateMissesLabel();
        }


        // HELPERS
        public void ResetLayout()
        {
            WordDisplay.Text = "";
            A_select.BackColor = Label.DefaultBackColor;
            B_select.BackColor = Label.DefaultBackColor;
            C_select.BackColor = Label.DefaultBackColor;
            D_select.BackColor = Label.DefaultBackColor;
            E_select.BackColor = Label.DefaultBackColor;
            F_select.BackColor = Label.DefaultBackColor;
            G_select.BackColor = Label.DefaultBackColor;
            H_select.BackColor = Label.DefaultBackColor;
            I_select.BackColor = Label.DefaultBackColor;
            J_select.BackColor = Label.DefaultBackColor;
            K_select.BackColor = Label.DefaultBackColor;
            L_select.BackColor = Label.DefaultBackColor;
            M_select.BackColor = Label.DefaultBackColor;
            N_select.BackColor = Label.DefaultBackColor;
            O_select.BackColor = Label.DefaultBackColor;
            P_select.BackColor = Label.DefaultBackColor;
            Q_select.BackColor = Label.DefaultBackColor;
            R_select.BackColor = Label.DefaultBackColor;
            S_select.BackColor = Label.DefaultBackColor;
            T_select.BackColor = Label.DefaultBackColor;
            U_select.BackColor = Label.DefaultBackColor;
            V_select.BackColor = Label.DefaultBackColor;
            W_select.BackColor = Label.DefaultBackColor;
            X_select.BackColor = Label.DefaultBackColor;
            Y_select.BackColor = Label.DefaultBackColor;
            Z_select.BackColor = Label.DefaultBackColor;
        }

        private void GameFailed()
        {
            OutputWindow.Text = $"FAILED! Word was {Game.GetCurrentWord()}";
        }

        private void GameSuccess()
        {
            OutputWindow.Text = "SUCCESS";
        }



    }
}
