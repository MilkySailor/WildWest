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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new difficulty());

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Options());
        }

        
    }
}
