using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
            this.Icon = global::Battleships.Properties.Resources.Boat;
            this.MaximizeBox = false;
            this.Name = "BattleShipsForm";
            this.Text = "Battleships";
            this.Load += new System.EventHandler(this.BattleShipsForm_Load);
            this.ResumeLayout(false);

        }

        private void BattleShipsForm_Load(object sender, EventArgs e)
        {
            MainMenu mainMenuView = new MainMenu();
            PlayMusic("MakaiSymphonyTheArmyofMinotaur.wav");
            this.Controls.Add(mainMenuView);

        }

        /*
         * Song: 'Makai Symphony - The Army of Minotaur' is under a creative commons license.
            https://www.youtube.com/channel/UC8cn3OdeqYhyhNUyrMxOQKQ
         */
        private void PlayMusic(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@filePath);
                player.PlayLooping();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            
        }

        private void StopMusic(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@filePath);
                player.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
