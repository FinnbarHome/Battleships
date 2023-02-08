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
    public partial class Score : UserControl
    {
        public Score()
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
    }
}
