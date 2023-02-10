using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NumPlayerControl numPlayerView = new NumPlayerControl();
            this.ParentForm.Controls.Add(numPlayerView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Title = "Save BattleShips";
            loadFile.AddExtension = true;
            loadFile.DefaultExt = ".battleshipSave";
            loadFile.Filter = "Battleships Save file|*.battleshipSave";
            loadFile.ShowDialog();
            GameState gameState = null;
            if(loadFile.FileName != null)
            {
                return;
            }
     
            gameState = GameState.loadFromFile(loadFile.FileName);
            if(gameState == null)
            {
                MessageBox.Show("Failed to load file");
                return;
            }
            /* When you continue, pass gameState to the main grid and switch the view */
            MainGrid mainGridView = new MainGrid(gameState);
            this.ParentForm.Controls.Add(mainGridView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            /* Move to the rules view */
            Rules ruleView = new Rules();
            this.ParentForm.Controls.Add(ruleView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            Score scoreView = new Score();
            this.ParentForm.Controls.Add(scoreView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /* Exit the game */
            this.ParentForm.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
