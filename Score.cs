using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Score : UserControl
    {
        Tuple<String, int>[] scores = new Tuple<String, int>[5];
        private int scoreToSet;
        public Score()
        {
            InitializeComponent();

            setupTable();
            updateTable();
        }

        public Score(GameState gameState)
        {
            InitializeComponent();
            lblYourScore.Text = "Your Score: " + gameState.score;
            scoreToSet = gameState.score;
            lblYourScore.Visible = true;
            lblEnterName.Visible = true;
            btnSubmit.Visible = true;
            TxtEnterName.Visible = true;
            setupTable();
            updateTable();

        }

        private void updateTable()
        {
            scoreDataTable.Rows.Clear();
            for (int i = 0; i < scores.Length; i += 1)
            {
                if (scores[i] == null)
                {
                    return;
                }
                scoreDataTable.Rows.Add(scores[i].Item1, scores[i].Item2);

            }
        }

        private void setupTable()
        {
            try
            {
                String[] scoreLines = File.ReadAllLines("Scores.txt");
                for (int i = 0; i < scoreLines.Length; i += 1)
                {
                    String[] scoreLine = scoreLines[i].Split(';');
                    scores[i] = new Tuple<String, int>(scoreLine[0], Convert.ToInt32(scoreLine[1]));
                }

            }
            catch (Exception)
            {
            }
        }
            private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            /* Load the main menu view and unload the rules view. */
            MainMenu mainMenuView = new MainMenu();
            this.ParentForm.Controls.Add(mainMenuView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(TxtEnterName.Text == "" || TxtEnterName.Text.Contains(";"))
            {
                return;
            }
            for(int i = 0; i < scores.Length; i += 1)
            {
                if (scores[i] == null)
                {
                    scores[i] = new Tuple<string, int>(TxtEnterName.Text, scoreToSet);
                    break;
                }
                if(scoreToSet > scores[i].Item2)
                {
                    for (int j = scores.Length - 1; j > i; j -= 1)
                    {
                        scores[j] = scores[j-1];
                    }
                    scores[i] = new Tuple<string, int>(TxtEnterName.Text, scoreToSet);
                    break;
                }
            }
            btnSubmit.Enabled = false;

            StreamWriter f = null;
            try
            {
                if(File.Exists("Scores.txt")){
                  File.Delete("Scores.txt");
                }

                f = new System.IO.StreamWriter("Scores.txt");
                for (int i = 0; i < scores.Length; i += 1)
                {
                    if (scores[i] == null)
                    {
                        break;
                    }
                    f.WriteLine(scores[i].Item1 + ";" + scores[i].Item2.ToString());
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                if (f != null)
                {
                    f.Close();
                }
            }
            updateTable();
        }
    }
}
