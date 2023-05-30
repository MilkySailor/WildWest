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
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Menu());
        }

        private void solvietButton_Click(object sender, EventArgs e)
        {
         
        }
    }
}
