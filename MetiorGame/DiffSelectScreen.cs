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
    public partial class DiffSelectScreen : UserControl
    {
        SoundPlayer shot = new SoundPlayer();
        public static int diffuicultyLevel = 0;
        public DiffSelectScreen()
        {
            InitializeComponent();
            
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 2;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 1;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            Form1.ChangeScreen(this, new Menu());
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 3;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void mediumButton_Click_1(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 2;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void easyButton_Click_1(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 1;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            shot = new SoundPlayer(Properties.Resources._9mm_pistol_shot_6349);
            shot.Play();
            diffuicultyLevel = 1;
            Form1.ChangeScreen(this, new Tutorial());
        }
    }
}
