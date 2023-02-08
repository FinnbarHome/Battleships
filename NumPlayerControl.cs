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
    public partial class NumPlayerControl : UserControl
    {
        public NumPlayerControl()
        {
            InitializeComponent();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            /* If we're starting a 1 player game we need to move to the difficulty view. */
            SelectDifficulty difficultyView = new SelectDifficulty();
            this.ParentForm.Controls.Add(difficultyView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            MainGrid mainGridView = new MainGrid(new GameState(Difficulty.TWOPLAYER));
            this.ParentForm.Controls.Add(mainGridView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }
    }
}
