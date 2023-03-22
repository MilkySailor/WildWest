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
    
    public partial class Win : UserControl
    {
        int gifTime = 0;
        public Win()
        {
            InitializeComponent();

            gifTimer.Start();

        }
        
        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Menu());
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new difficulty());
        }

        private void gifTimer_Tick(object sender, EventArgs e)
        {
            gifTime++;
            if(gifTime == 53)
            {
                gif.Visible = false;
            }
        }
    }
}
