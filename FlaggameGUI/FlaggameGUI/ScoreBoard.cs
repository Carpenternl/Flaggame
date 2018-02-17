using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaggameGUI
{
    public partial class ScoreBoard : UserControl
    {
        int currentscore = 0;
        int lastscore;
        int highscore;
        double avg;
        public ScoreBoard()
        {
            InitializeComponent();
            recentscores = new List<bool>();
            
        }
        public void updateScoreBoard(bool win)
        {
            if (win)
            {
                WinCondition();
            }
            else { LossCondition(); }
            updateAverage(win);
            updateDisplay();
        }
        private void WinCondition()
        {
            currentscore++;
            if (highscore < currentscore)
            {
                highscore = currentscore;
            }
            
        }
        private void LossCondition()
        {
            lastscore = currentscore;
            currentscore = 0;
        }
        private void updateDisplay()
        {
            LabelCurrenctScoreDisplay.Text = currentscore.ToString();
            LabelLastScoreDisplay.Text = lastscore.ToString();
            LabelHighScoreDisplay.Text = highscore.ToString();
            LabelAccuracyDisplay.Text = "%"+((int)(avg * 100)).ToString();
        }
        /// <summary>
        ///  returns the average accuracy of your last 100 answers
        /// </summary>
        /// <param name="wincondition">whether the current answer was correct or not</param>

        List<bool> recentscores;
        int loop = 0;
        private void updateAverage(bool wincondition)
        {
            
            // only create an average for the last 100 results
            if (recentscores.Count < 100)
            {
                recentscores.Add(wincondition);
            }
            else
            {  
                recentscores[loop] = wincondition;
                loop++;
                if (loop >= recentscores.Count())
                {
                    loop = 0;
                }

            }
            int wins = recentscores.Count(item => item == true);
            int total = recentscores.Count();
            avg = (double) wins / total;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateScoreBoard(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateScoreBoard(false);
        }
    }
}
