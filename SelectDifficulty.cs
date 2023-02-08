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
    public partial class SelectDifficulty : UserControl
    {
        public SelectDifficulty()
        {
            InitializeComponent();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
                /* Load the main menu view and unload the rules view. */
                MainMenu mainMenuView = new MainMenu();
                this.ParentForm.Controls.Add(mainMenuView);
                this.ParentForm.Controls.Remove(this);
                this.Dispose();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            /* All the difficulty buttons have one handler, their Tag field contains their difficulty. */
            Button btn = (Button)sender;
            /* Initialise the choose places grid with our GameState Class. */
            ChoosePlacesGrid choosePlaces = new ChoosePlacesGrid(new GameState((Difficulty)btn.Tag));
            this.ParentForm.Controls.Add(choosePlaces);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }
    }
}
