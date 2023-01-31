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
    public partial class BattleShipsForm : Form
    {
        public BattleShipsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BattleShipsForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BattleShipsForm";
            this.Text = "Battleships";
            this.ResumeLayout(false);
            this.Controls.Add(new MainMenu());
        }
    }
}
