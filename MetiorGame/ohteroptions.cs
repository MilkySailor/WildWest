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
    public partial class ohteroptions : UserControl
    {
        public ohteroptions()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new blyat());
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Options());
        }

        
    }
}
