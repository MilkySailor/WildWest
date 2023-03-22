using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetiorGame
{
    public partial class difficulty : UserControl
    {
        public difficulty()
        {
            InitializeComponent();
        }
        public static int diffuicultyLevel = 0;


        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Menu());

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            diffuicultyLevel = 1; 
            Form1.ChangeScreen(this, new GameScreen());

        }

        private void medButton_Click(object sender, EventArgs e)
        {
            diffuicultyLevel = 2;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            diffuicultyLevel = 3;
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
