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

        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules ruleView = new Rules();
            this.ParentForm.Controls.Add(ruleView);
            this.ParentForm.Controls.Remove(this);
            this.Dispose();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
