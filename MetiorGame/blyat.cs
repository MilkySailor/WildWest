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
    public partial class blyat : UserControl
    {
        
        public blyat()
        {
            InitializeComponent();
            
        }


        private void optionsButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ohteroptions());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CommieDifficulty());
        }
    }
}
