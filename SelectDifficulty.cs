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

        private void lblReturnToMainMenu_Click(object sender, EventArgs e)
        {
                MainMenu mainMenuView = new MainMenu();
                this.ParentForm.Controls.Add(mainMenuView);
                this.ParentForm.Controls.Remove(this);
                this.Dispose();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChoosePlacesGrid choosePlaces = new ChoosePlacesGrid(new GameState((Difficulty)btn.Tag));
            this.ParentForm.Controls.Add(choosePlaces);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }
    }
}
