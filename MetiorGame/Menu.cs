using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MetiorGame
{
    public partial class Menu : UserControl
    {
        bool FkeyDown = false;
        SoundPlayer shot = new SoundPlayer();
        SoundPlayer menuTheme = new SoundPlayer();
        public Menu()
        {
            InitializeComponent();
            menuTheme = new SoundPlayer(Properties.Resources.Neil_LeVang___Ghost_Riders_In_The_Sky__1961__4K);
            menuTheme.Play();
        }
        

        private void playButton_Click(object sender, EventArgs e)
        { 
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new DiffSelectScreen());

        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    FkeyDown = true;
                    break;
            }
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    FkeyDown = true;
                    break;
            }
        }
    }
}
