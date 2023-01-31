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
    }
}
